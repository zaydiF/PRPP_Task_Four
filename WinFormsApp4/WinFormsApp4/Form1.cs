using System;
using System.Windows.Forms;

namespace BookVisitorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Создание книги с введёнными данными
        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.title = txtTitle.Text;
            book.author = txtAuthor.Text;
            if (int.TryParse(txtYear.Text, out int year))
                book.year = year;
            else
                book.year = 0;

            listBoxBooks.Items.Clear();
            listBoxBooks.Items.Add(book.GetInfo());
        }

        // Книга со значениями по умолчанию
        private void btnDefaultBook_Click(object sender, EventArgs e)
        {
            Book unknownBook = new Book();
            listBoxBooks.Items.Clear();
            listBoxBooks.Items.Add(unknownBook.GetInfo());
        }

        // Добавление нового посетителя
        private void btnAddVisitor_Click(object sender, EventArgs e)
        {
            string name = txtVisitorName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя посетителя.");
                return;
            }

            Visitor visitor = new Visitor(name);
            listBoxVisitors.Items.Add(visitor.GetInfo());

            // Обновление общего количества посетителей
            lblTotalVisitors.Text = $"Всего посетителей: {Visitor.GetTotalVisitors()}";
        }

        // Инициализация при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotalVisitors.Text = "Всего посетителей: 0";
        }
    }

    // Класс Book (можно вынести в отдельный файл)
    public class Book
    {
        public string title = "Неизвестно";
        public string author = "Неизвестен";
        public int year;

        public string GetInfo()
        {
            return $"«{title}», {author} ({year})";
        }
    }

    // Класс Visitor
    public class Visitor
    {
        public string name;
        private static int totalVisitors = 0;

        public Visitor(string name)
        {
            this.name = name;
            totalVisitors++;
        }

        public string GetInfo()
        {
            return $"Имя посетителя: {name}";
        }

        public static int GetTotalVisitors()
        {
            return totalVisitors;
        }
    }
}