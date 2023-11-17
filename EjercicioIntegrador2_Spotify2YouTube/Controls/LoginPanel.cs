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


        public event EventHandler LoginClick;
        public event EventHandler SignupClick;
        private ImageList imgList;
        private int imgIndex = 0;
        private Color fontColor = Color.Black;
        private Credentials Credentials { get => new Credentials(tbUsername.Text, tbPassword.Text); }
        private LoginService loginService;
        public LoginService LoginService { set => loginService = value; }


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
            var user = await this.loginService.Login(Credentials);
            if (user is null)
            {
                this.lblLoginError.Visible = true;
            }
            else
            {
                this.lblLoginError.Visible = false;
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
            this.OnLoginClick(EventArgs.Empty);
        }
        protected virtual void OnSignupClick(EventArgs e)
        {
            SignupClick?.Invoke(this, e);
        }
    }
}
