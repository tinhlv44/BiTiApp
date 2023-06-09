using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTiApp
{
    public class MyMessageBox : UserControl//một thứ giống messbox nhưng chưa hoàn thiện
    {
        private Label messageLabel;
        private PictureBox iconPictureBox;
        private Button okButton;
        private Button cancelButton;

        public MyMessageBox()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Khởi tạo các thành phần giao diện
            this.messageLabel = new Label();
            this.iconPictureBox = new PictureBox();
            this.okButton = new Button();
            this.cancelButton = new Button();

            // Đặt thuộc tính cho các thành phần giao diện
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new Point(60, 20);
            this.messageLabel.Font = new Font("Arial", 12);
            this.iconPictureBox.Location = new Point(20, 20);
            this.iconPictureBox.Size = new Size(30, 30);
            this.okButton.Location = new Point(120, 70);
            this.okButton.Text = "OK";
            this.cancelButton.Location = new Point(200, 70);
            this.cancelButton.Text = "Cancel";

            // Đăng ký sự kiện click cho các button
            this.okButton.Click += new EventHandler(OkButton_Click);
            this.cancelButton.Click += new EventHandler(CancelButton_Click);

            // Thêm thành phần giao diện vào UserControl
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);

            this.Size = new Size(400, 120); // Đặt kích thước cho UserControl
            this.Visible = false; // Không hiển thị UserControl khi chưa được sử dụng
        }

        // Hàm hiển thị MyMessageBox với các thông số đầu vào
        /*public DialogResult Show(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            this.messageLabel.Text = message;

            switch (icon)
            {
                case MessageBoxIcon.Error:
                    this.iconPictureBox.BackgroundImage = Image.FromFile("error.png");
                    break;
                case MessageBoxIcon.Information:
                    this.iconPictureBox.BackgroundImage = Image.FromFile("info.png");
                    break;
                case MessageBoxIcon.Question:
                    this.iconPictureBox.BackgroundImage = Image.FromFile("question.png");
                    break;
                case MessageBoxIcon.Warning:
                    this.iconPictureBox.BackgroundImage = Image.FromFile("warning.png");
                    break;
            }

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    this.okButton.Visible = true;
                    this.cancelButton.Visible = false;
                    break;
                case MessageBoxButtons.OKCancel:
                    this.okButton.Visible = true;
                    this.cancelButton.Visible = true;
                    break;
            }

            this.Visible = true;
            this.Parent.Enabled = false; // Khóa cửa sổ cha

            DialogResult result = DialogResult.Cancel;
            if (this.okButton.Visible)
            {
                result = this.okButton.ShowDialog();
            }
            else
            {
                result = this.cancelButton.ShowDialog();
            }

            this.Parent.Enabled = true; // Mở khóa cửa sổ cha
            this.Visible = false;
            return result;
        }*/

        // Xử lý sự kiện click cho button OK
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.okButton.DialogResult = DialogResult.OK;
            this.ParentForm.Close();
        }

        // Xử lý sự kiện click cho button Cancel
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.cancelButton.DialogResult = DialogResult.Cancel;
            this.ParentForm.Close();
        }
        /*MyMessageBox messageBox = new MyMessageBox();
        DialogResult result = messageBox.Show("This is a message", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
    }
}
