using Repositories.Entities;
using Services;

namespace BookStore_Vidaibao
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GetConnectionString());
            
            string email = txtEmail.Text; //TODO: kiểm tra rỗng!!!
            string password = txtPassword.Text; //TODO: kiểm tra rỗng
            
            BookManagementMemberService se = new BookManagementMemberService(); ;

            BookManagementMember? account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }
            //not null rồi, và ngon rồi, cho vào form Quản lí sách
            //nhưng chỉ vào nếu role là ADMIN
            if (account.MemberRole != 1)
            {
                MessageBox.Show("You are not allowed to access this function!",
                                "Access denied", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //ngon, role ADMIN thì mở from ĐỎ SAO VÀNG LÊN
            BookManagerForm bookMgt = new BookManagerForm();
            bookMgt.Show(); //show form CRUD
            this.Hide();  //ẩn form login đi
            
        }


        


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}