namespace ThreadingDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnProcess1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("islem 1 calisti");
    }

    private void btnProcess2_Click(object sender, EventArgs e)
    {
        MessageBox.Show("islem 2 calisti");
    }
    
    // SingleThread yapılarda bir işlem bitmeden ikinci işlem yapılmaz
    // MultiThread yapılarada sisteme bağlı olarak birden fazla Thread oluşturulur ve işlemler farklı Thread'lerde gerçekleştirilir
    // async yapılarada bir Thread'e birden fazla işlem aynı anda girebilir veya birden fazla Thread de oluşturulabilir duruma bağlı olarak
}