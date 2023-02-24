
namespace RentAgencyProject
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.txtBx_F = new System.Windows.Forms.TextBox();
            this.txtBx_I = new System.Windows.Forms.TextBox();
            this.txtBx_O = new System.Windows.Forms.TextBox();
            this.tabCtrl_Login = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txtBx_Pwd = new System.Windows.Forms.TextBox();
            this.txtBx_Login = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_regPwd = new System.Windows.Forms.Label();
            this.txtBx_Tel = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.DTPkr_DR = new System.Windows.Forms.DateTimePicker();
            this.lbl_DR = new System.Windows.Forms.Label();
            this.lbl_F = new System.Windows.Forms.Label();
            this.lbl_I = new System.Windows.Forms.Label();
            this.lbl_O = new System.Windows.Forms.Label();
            this.tabCtrl_Login.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Login.Location = new System.Drawing.Point(152, 167);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 32);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Войти";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Reg
            // 
            this.btn_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Reg.Location = new System.Drawing.Point(104, 232);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(168, 32);
            this.btn_Reg.TabIndex = 1;
            this.btn_Reg.Text = "Зарегистрироваться";
            this.btn_Reg.UseVisualStyleBackColor = true;
            this.btn_Reg.Click += new System.EventHandler(this.btn_Reg_Click);
            // 
            // txtBx_F
            // 
            this.txtBx_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_F.Location = new System.Drawing.Point(144, 16);
            this.txtBx_F.Name = "txtBx_F";
            this.txtBx_F.Size = new System.Drawing.Size(208, 23);
            this.txtBx_F.TabIndex = 2;
            // 
            // txtBx_I
            // 
            this.txtBx_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_I.Location = new System.Drawing.Point(144, 47);
            this.txtBx_I.Name = "txtBx_I";
            this.txtBx_I.Size = new System.Drawing.Size(208, 23);
            this.txtBx_I.TabIndex = 2;
            // 
            // txtBx_O
            // 
            this.txtBx_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_O.Location = new System.Drawing.Point(144, 79);
            this.txtBx_O.Name = "txtBx_O";
            this.txtBx_O.Size = new System.Drawing.Size(208, 23);
            this.txtBx_O.TabIndex = 2;
            // 
            // tabCtrl_Login
            // 
            this.tabCtrl_Login.Controls.Add(this.tabPage1);
            this.tabCtrl_Login.Controls.Add(this.tabPage2);
            this.tabCtrl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabCtrl_Login.Location = new System.Drawing.Point(208, 24);
            this.tabCtrl_Login.Name = "tabCtrl_Login";
            this.tabCtrl_Login.SelectedIndex = 0;
            this.tabCtrl_Login.Size = new System.Drawing.Size(384, 312);
            this.tabCtrl_Login.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.lbl_Pwd);
            this.tabPage1.Controls.Add(this.btn_Login);
            this.tabPage1.Controls.Add(this.lbl_Login);
            this.tabPage1.Controls.Add(this.txtBx_Pwd);
            this.tabPage1.Controls.Add(this.txtBx_Login);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Войти";
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Pwd.Location = new System.Drawing.Point(120, 88);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(136, 23);
            this.lbl_Pwd.TabIndex = 6;
            this.lbl_Pwd.Text = "Пароль";
            this.lbl_Pwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Login
            // 
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Login.Location = new System.Drawing.Point(120, 16);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(136, 23);
            this.lbl_Login.TabIndex = 5;
            this.lbl_Login.Text = "Логин (телефон)";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBx_Pwd
            // 
            this.txtBx_Pwd.Location = new System.Drawing.Point(80, 120);
            this.txtBx_Pwd.Name = "txtBx_Pwd";
            this.txtBx_Pwd.Size = new System.Drawing.Size(216, 23);
            this.txtBx_Pwd.TabIndex = 1;
            // 
            // txtBx_Login
            // 
            this.txtBx_Login.Location = new System.Drawing.Point(80, 48);
            this.txtBx_Login.Name = "txtBx_Login";
            this.txtBx_Login.Size = new System.Drawing.Size(216, 23);
            this.txtBx_Login.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.lbl_regPwd);
            this.tabPage2.Controls.Add(this.txtBx_Tel);
            this.tabPage2.Controls.Add(this.lbl_Tel);
            this.tabPage2.Controls.Add(this.DTPkr_DR);
            this.tabPage2.Controls.Add(this.lbl_DR);
            this.tabPage2.Controls.Add(this.lbl_F);
            this.tabPage2.Controls.Add(this.btn_Reg);
            this.tabPage2.Controls.Add(this.txtBx_O);
            this.tabPage2.Controls.Add(this.lbl_I);
            this.tabPage2.Controls.Add(this.txtBx_I);
            this.tabPage2.Controls.Add(this.lbl_O);
            this.tabPage2.Controls.Add(this.txtBx_F);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Зарегистрироваться";
            // 
            // lbl_regPwd
            // 
            this.lbl_regPwd.Location = new System.Drawing.Point(24, 184);
            this.lbl_regPwd.Name = "lbl_regPwd";
            this.lbl_regPwd.Size = new System.Drawing.Size(328, 24);
            this.lbl_regPwd.TabIndex = 8;
            // 
            // txtBx_Tel
            // 
            this.txtBx_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_Tel.Location = new System.Drawing.Point(144, 144);
            this.txtBx_Tel.Name = "txtBx_Tel";
            this.txtBx_Tel.Size = new System.Drawing.Size(208, 23);
            this.txtBx_Tel.TabIndex = 7;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Tel.Location = new System.Drawing.Point(24, 144);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(112, 23);
            this.lbl_Tel.TabIndex = 6;
            this.lbl_Tel.Text = "Телефон +7";
            // 
            // DTPkr_DR
            // 
            this.DTPkr_DR.Location = new System.Drawing.Point(144, 112);
            this.DTPkr_DR.Name = "DTPkr_DR";
            this.DTPkr_DR.Size = new System.Drawing.Size(208, 23);
            this.DTPkr_DR.TabIndex = 5;
            // 
            // lbl_DR
            // 
            this.lbl_DR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DR.Location = new System.Drawing.Point(24, 111);
            this.lbl_DR.Name = "lbl_DR";
            this.lbl_DR.Size = new System.Drawing.Size(111, 23);
            this.lbl_DR.TabIndex = 4;
            this.lbl_DR.Text = "Дата рождения";
            // 
            // lbl_F
            // 
            this.lbl_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_F.Location = new System.Drawing.Point(24, 16);
            this.lbl_F.Name = "lbl_F";
            this.lbl_F.Size = new System.Drawing.Size(112, 23);
            this.lbl_F.TabIndex = 4;
            this.lbl_F.Text = "Фамилия";
            // 
            // lbl_I
            // 
            this.lbl_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_I.Location = new System.Drawing.Point(24, 48);
            this.lbl_I.Name = "lbl_I";
            this.lbl_I.Size = new System.Drawing.Size(112, 23);
            this.lbl_I.TabIndex = 4;
            this.lbl_I.Text = "Имя";
            // 
            // lbl_O
            // 
            this.lbl_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_O.Location = new System.Drawing.Point(24, 80);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(112, 23);
            this.lbl_O.TabIndex = 4;
            this.lbl_O.Text = "Отчество";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCtrl_Login);
            this.Name = "LoginForm";
            this.Text = "Агентство по аренде квартир \"Уголок\"";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tabCtrl_Login.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.TextBox txtBx_F;
        private System.Windows.Forms.TextBox txtBx_I;
        private System.Windows.Forms.TextBox txtBx_O;
        private System.Windows.Forms.TabControl tabCtrl_Login;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_F;
        private System.Windows.Forms.Label lbl_I;
        private System.Windows.Forms.Label lbl_O;
        private System.Windows.Forms.Label lbl_DR;
        private System.Windows.Forms.DateTimePicker DTPkr_DR;
        private System.Windows.Forms.TextBox txtBx_Tel;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox txtBx_Pwd;
        private System.Windows.Forms.TextBox txtBx_Login;
        private System.Windows.Forms.Label lbl_regPwd;
    }
}

