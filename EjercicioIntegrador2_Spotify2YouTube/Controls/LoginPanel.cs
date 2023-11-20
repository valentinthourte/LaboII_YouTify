using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services.Base;
using Entities.Model;

namespace EjercicioIntegrador2_YouTify
{
    public partial class LoginPanel : UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private const string TEXT_SIGNUP_CREDENTIALS_INVALID = "That username is already in use.";
        private const string TEXT_FIELDS_MUST_HAVE_VALUE = "Both username and password fields must have values.";
        private const string TEXT_LOGIN_CREDENTIALS_INVALID = "Username or password was incorrect. Try again.";


        public event EventHandler LoginClick;
        public event EventHandler SignupClick;
        private ImageList imgList;
        private int imgIndex = 0;
        private Color fontColor = Color.Black;
        private Credentials Credentials { get => new Credentials(tbUsername.Text, tbPassword.Text); }
        private UserService loginService;
        public UserService LoginService { set => loginService = value; }


        public Color FontColor
        {
            get { return fontColor; }
            set
            {
                fontColor = value;
                SetFontColorForAllControls(value, this.Controls);
            }
        }

        private void SetFontColorForAllControls(Color color, ControlCollection collection)
        {
            foreach (Control c in collection)
            {
                if (c.Controls.Count > 0)
                {
                    SetFontColorForAllControls(color, c.Controls);
                }
                this.ForeColor = color;
                if (MustChangeControlColor(c.GetType()))
                {
                    c.ForeColor = color;
                }
            }
        }

        private bool MustChangeControlColor(Type type)
        {
            List<Type> unacceptedTypes = new List<Type> { typeof(Button), typeof(TextBox) };

            return !unacceptedTypes.Contains(type);
        }

        public async Task<User> Login()
        {
            User user = null;
            try
            {
                user = await this.loginService.Login(Credentials);
                if (user is null)
                {
                    this.lblError.Text = TEXT_LOGIN_CREDENTIALS_INVALID;
                    this.lblError.Visible = true;
                }
                else
                {
                    this.lblError.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred during login: {ex.Message}");
            }

            return user;
        }

        public async Task<User> Signup()
        {
            User user = null;
            try
            {
                user = await this.loginService.Signup(Credentials);
                if (user is null)
                {
                    lblError.Text = TEXT_SIGNUP_CREDENTIALS_INVALID;
                    lblError.Visible = true;
                }
                else
                {
                    this.lblError.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred during signup: {ex.Message}");
            }
            return user;
        }

        public int ImgIndex
        {
            get { return imgIndex; }
            set
            {
                imgIndex = value;
                lblLogo.ImageIndex = value;
            }
        }

        public ImageList ImgList
        {
            get { return imgList; }
            set
            {
                imgList = value;
                lblLogo.ImageList = value;
            }
        }


        protected virtual void OnLoginClick(EventArgs e)
        {
            LoginClick?.Invoke(this, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == String.Empty || tbPassword.Text == string.Empty)
            {
                lblError.Text = TEXT_FIELDS_MUST_HAVE_VALUE;
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
                this.OnLoginClick(EventArgs.Empty);
            }
        }
        protected virtual void OnSignupClick(EventArgs e)
        {
            SignupClick?.Invoke(this, e);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == String.Empty || tbPassword.Text == string.Empty)
            {
                lblError.Text = TEXT_FIELDS_MUST_HAVE_VALUE;
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
                this.OnSignupClick(EventArgs.Empty);
            }
        }
    }
}
