using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountLibrary;
using System.IO;

namespace AccountWindowsApp
{
    public partial class Form1 : Form
    {
        private Accounts accounts;
        public Form1()
        {
            InitializeComponent();
            accounts = new Accounts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse(textDateInput2.Text);
            updateLeft();
        }

        private void create_item(object sender, EventArgs e)
        {
            if (checkInput())
            {
                string name = textName.Text;
                CategoryType categoryType = (CategoryType)System.Enum.Parse(typeof(CategoryType), textCategory.SelectedIndex.ToString());
                double moneyValue = double.Parse(textAmount.Text);
                MoneyType moneyType = textCurrency.SelectedIndex == -1? MoneyType.RMB :(MoneyType)System.Enum.Parse(typeof(MoneyType), textCurrency.SelectedIndex.ToString());
                Money money = new Money(moneyValue, moneyType);
                DateTime dateTime = DateTime.Parse(textDateInput.Text);
                string content = textContent.Text;
                string note = textNote.Text;
                AccountItem item = new AccountItem(name, categoryType, money, dateTime, content, note);
                this.accounts.addItem(item);
                updateLeft();
                MessageBox.Show("成功添加账单！");
            }
            else
            {
                MessageBox.Show("请重新检查输入的账单！");
            }
            
        }

        private void textDateInput2_ValueChanged(object sender, EventArgs e)
        {
            updateLeft();
        }
        private void updateLeft()
        {
            DateTime time = DateTime.Parse(textDateInput2.Text);
            textIncome.Text = $"{accounts.TotalIncome(time)}";
            textExpend.Text = $"{accounts.TotalExpend(time)}";
            textTotal.Text = $"{accounts.TotalRevenue(time)}";
            listView1.Items.Clear();
            foreach (AccountItem item in accounts.Display(time))
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = item.Name;
                if (item.Category == 0)
                {
                    listItem.SubItems.Add("收入");
                }
                else
                {
                    listItem.SubItems.Add("支出");
                }
                listItem.SubItems.Add($"{item.Amount.MoneyValue}{item.Amount.type}");
                listItem.SubItems.Add(item.OccuredTime.ToString("yyyy/MM/dd"));
                listItem.SubItems.Add(item.Note);
                listView1.Items.Add(listItem);
            }
        }
        private bool checkInput()
        {
            if (textName.Text == "" || textCategory.SelectedItem.ToString() == "" || textAmount.Text == "")
            {
                return false;
            }
            double amountResult;
            if (!Double.TryParse(textAmount.Text, out amountResult))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void importAccounts(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("../../../accounts.txt"))
                {
                    foreach (AccountItem item in accounts.Display())
                    {
                        sw.WriteLine(item);
                    }
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("导出成功！");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("导出错误！");
                Console.WriteLine(ex);
            }
        }

    }
}
