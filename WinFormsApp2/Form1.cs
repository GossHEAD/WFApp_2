using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.Entity.Core.Mapping;
using System.Data.SQLite;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinFormsApp2.SqlQuery;

namespace WinFormsApp2;

public partial class Form1 : Form
{
    private List<Product> _list;
    public Form1()
    {

        InitializeComponent();
        _list = new List<Product>();
        productBindingSource3.DataSource = _list;
        List<Product> list = ConnectionToSQLAndShowProducts();
        if (list != null && list.Count > 0)
        {
            _list.AddRange(list);
            productBindingSource3.ResetBindings(false);
        }
        dataGridViewProducts.AutoGenerateColumns = true;
    }
    private void button1_Click(object sender, EventArgs e)
    {
        _list.Clear();
        List<Product> list = ConnectionToSQLAndShowProducts();
        if (list != null && list.Count > 0)
        {
            _list.AddRange(list);
            productBindingSource3.ResetBindings(false);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        using (Form2 form2 = new Form2())
        {
            int row = dataGridViewProducts.CurrentCell.RowIndex;
            if (dataGridViewProducts.CurrentCell.RowIndex == null) row = 0;
            int index = (int)dataGridViewProducts.Rows[row].Cells[0].Value;
            if (form2.ShowDialog() == DialogResult.OK)
            {
                _list.Clear();
                List<Product> list = AddAndShowProducts(index,
                form2.textBoxForm2Name.Text,
                Convert.ToInt32(form2.textBoxForm2Count.Text),
                form2.textBoxForm2Category.Text);
                if (list != null && list.Count > 0)
                {
                    _list.AddRange(list);
                    productBindingSource3.ResetBindings(false);
                }
            }

        }
    }
    private void button3_Click(object sender, EventArgs e)
    {
        int row = dataGridViewProducts.CurrentCell.RowIndex;
        int index = (int)dataGridViewProducts.Rows[row].Cells[0].Value;
        _list.Clear();
        DialogResult result = MessageBox.Show(
                               "Вы точно хотите удалить запись?",
                               "Сообщение",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly);
        if (result == DialogResult.Yes)
        {
            List<Product> list = DeleteAndShowProducts(index);
            if (list != null && list.Count > 0)
            {
                _list.AddRange(list);
                productBindingSource3.ResetBindings(false);
            }
        }
        else
        {
            List<Product> list = ConnectionToSQLAndShowProducts();
            if (list != null && list.Count > 0)
            {
                _list.AddRange(list);
                productBindingSource3.ResetBindings(false);
            }
        }
    }

    private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        textBoxName.Visible = true;
        textBoxCount.Visible = true;
        textBoxCategory.Visible = true;

        label1.Visible = true;
        label2.Visible = true;
        label3.Visible = true;

        textBoxName.Text = dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
        textBoxCount.Text = dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
        textBoxCategory.Text = dataGridViewProducts.CurrentRow.Cells[3].Value.ToString();


    }

    private void textBox1_KeyUp(object sender, KeyEventArgs e)
    {
        int row = dataGridViewProducts.CurrentCell.RowIndex;
        int index = (int)dataGridViewProducts.Rows[row].Cells[0].Value;
        try
        {
            if (e.KeyCode == Keys.Enter)
            {
                _list.Clear();
                List<Product> list = UpdateAndShowProducts(index, textBoxName.Text, Convert.ToInt32(textBoxCount.Text),
                                                     textBoxCategory.Text);
                if (list != null && list.Count > 0)
                {
                    _list.AddRange(list);
                    productBindingSource3.ResetBindings(false);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:" + ex.Message);
        }
    }

    private void textBox2_KeyUp(object sender, KeyEventArgs e)
    {
        int row = dataGridViewProducts.CurrentCell.RowIndex;
        int index = (int)dataGridViewProducts.Rows[row].Cells[0].Value;
        try
        {
            if (e.KeyCode == Keys.Enter)
            {
                _list.Clear();
                List<Product> list = UpdateAndShowProducts(index, textBoxName.Text, Convert.ToInt32(textBoxCount.Text),
                                                     textBoxCategory.Text);
                if (list != null && list.Count > 0)
                {
                    _list.AddRange(list);
                    productBindingSource3.ResetBindings(false);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:" + ex.Message);
        }
    }

    private void textBox3_KeyUp(object sender, KeyEventArgs e)
    {
        int row = dataGridViewProducts.CurrentCell.RowIndex;
        int index = (int)dataGridViewProducts.Rows[row].Cells[0].Value;
        try
        {
            if (e.KeyCode == Keys.Enter)
            {
                _list.Clear();
                List<Product> list = UpdateAndShowProducts(index, textBoxName.Text, Convert.ToInt32(textBoxCount.Text),
                                                     textBoxCategory.Text);
                if (list != null && list.Count > 0)
                {
                    _list.AddRange(list);
                    productBindingSource3.ResetBindings(false);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:" + ex.Message);
        }
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        try
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            using (StreamWriter writer = new StreamWriter(filename, false))
            {

                for (int i = 0; i < dataGridViewProducts.RowCount; i++)
                {
                    for (int j = 1; j < dataGridViewProducts.ColumnCount; j++)
                    {
                        string text = dataGridViewProducts.Rows[i].Cells[j].Value.ToString();
                        writer.Write(text);
                        writer.Write(" ");
                    }
                    writer.Write('\n');
                }
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Вы ввели неправильный путь до файла!");
        }
    }


    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        int index = dataGridViewProducts.RowCount;
        if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
        _list.Clear();
        List<Product> list = TruncateAllUsers();

        string filename = openFileDialog1.FileName;
        using (StreamReader reader = new StreamReader(filename))
        {
            //while (!reader.EndOfStream)
            //{
                string[] dataFromFile = File.ReadAllLines(filename);
                string[,] dataFromTheFile = new string[dataFromFile.Length, dataGridViewProducts.ColumnCount];
                for (int i = 0; i < dataFromFile.Length; i++)
                {
                    string[] coordinateStr = dataFromFile[i].Split( ' ');
                    for (int j = 0; j < 3; j++)
                    {
                        dataFromTheFile[i, j] = coordinateStr[j];
                    }
                    list = TakeFromFileAndShowProducts(dataFromTheFile[i, 0],
                                                    Convert.ToInt32(dataFromTheFile[i, 1]),
                                                    dataFromTheFile[i, 2]);

            
               }
            //}
        }
        if (list != null && list.Count > 0)
        {
            _list.AddRange(list);
            productBindingSource3.ResetBindings(false);
        }
    }

    private void ShowGreetings(object sender, EventArgs e)
    {
        bool showGreetingOn;

        var file = new StreamReader("ShowGreeting");
        string stringShowGreetingOn = file.ReadLine();
        showGreetingOn = Convert.ToBoolean(stringShowGreetingOn);
        file.Close();

        if (showGreetingOn)
        {
            var file1 = new StreamWriter("ShowGreeting", false);
            showGreetingOn = false;
            file1.WriteLine(showGreetingOn);
            file1.Close();
        }
        else
        {
            var file2 = new StreamWriter("ShowGreeting", false);
            showGreetingOn = true;
            file2.WriteLine(showGreetingOn);
            file2.Close();
        }

    }

    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Выйти?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}


