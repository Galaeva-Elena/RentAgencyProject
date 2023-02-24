
namespace RentAgencyProject
{
    partial class DealForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBx_mAptView = new System.Windows.Forms.ListBox();
            this.lbl_mApt = new System.Windows.Forms.Label();
            this.btn_mAptList = new System.Windows.Forms.Button();
            this.btn_addApt = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lstBx_mClntList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mClntList = new System.Windows.Forms.Button();
            this.mngrPnl = new System.Windows.Forms.Panel();
            this.btn_mExit = new System.Windows.Forms.Button();
            this.btn_appApprove = new System.Windows.Forms.Button();
            this.btn_mAppList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBx_mAppl = new System.Windows.Forms.ListBox();
            this.btn_blockClt = new System.Windows.Forms.Button();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_numOfRooms = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txtBx_Desc = new System.Windows.Forms.TextBox();
            this.txtBx_Price = new System.Windows.Forms.TextBox();
            this.txtBx_numOfRooms = new System.Windows.Forms.TextBox();
            this.txtBx_Size = new System.Windows.Forms.TextBox();
            this.txtBx_Address = new System.Windows.Forms.TextBox();
            this.clntPnl = new System.Windows.Forms.Panel();
            this.btn_viewAgrmt = new System.Windows.Forms.Button();
            this.Agrmnt = new System.Windows.Forms.Label();
            this.lbl_Agrmnt = new System.Windows.Forms.Label();
            this.lbl_appComm = new System.Windows.Forms.Label();
            this.txtBx_appComm = new System.Windows.Forms.TextBox();
            this.btn_Rent = new System.Windows.Forms.Button();
            this.btn_cApp = new System.Windows.Forms.Button();
            this.lbl_cApp = new System.Windows.Forms.Label();
            this.lstBx_cAppl = new System.Windows.Forms.ListBox();
            this.btn_RateAsmt = new System.Windows.Forms.Button();
            this.btn_cAptList = new System.Windows.Forms.Button();
            this.txtBx_Rate = new System.Windows.Forms.TextBox();
            this.btn_cExit = new System.Windows.Forms.Button();
            this.lbl_cApt = new System.Windows.Forms.Label();
            this.lstBx_cAptView = new System.Windows.Forms.ListBox();
            this.mngrPnl.SuspendLayout();
            this.clntPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBx_mAptView
            // 
            this.lstBx_mAptView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstBx_mAptView.FormattingEnabled = true;
            this.lstBx_mAptView.HorizontalScrollbar = true;
            this.lstBx_mAptView.Location = new System.Drawing.Point(0, 40);
            this.lstBx_mAptView.Name = "lstBx_mAptView";
            this.lstBx_mAptView.Size = new System.Drawing.Size(768, 82);
            this.lstBx_mAptView.TabIndex = 0;
            // 
            // lbl_mApt
            // 
            this.lbl_mApt.AutoSize = true;
            this.lbl_mApt.Location = new System.Drawing.Point(0, 16);
            this.lbl_mApt.Name = "lbl_mApt";
            this.lbl_mApt.Size = new System.Drawing.Size(88, 13);
            this.lbl_mApt.TabIndex = 1;
            this.lbl_mApt.Text = "Список квартир";
            // 
            // btn_mAptList
            // 
            this.btn_mAptList.Location = new System.Drawing.Point(688, 0);
            this.btn_mAptList.Name = "btn_mAptList";
            this.btn_mAptList.Size = new System.Drawing.Size(75, 32);
            this.btn_mAptList.TabIndex = 2;
            this.btn_mAptList.Text = "Обновить";
            this.btn_mAptList.UseVisualStyleBackColor = true;
            this.btn_mAptList.Click += new System.EventHandler(this.btn_mAptList_Click);
            // 
            // btn_addApt
            // 
            this.btn_addApt.Location = new System.Drawing.Point(0, 432);
            this.btn_addApt.Name = "btn_addApt";
            this.btn_addApt.Size = new System.Drawing.Size(75, 32);
            this.btn_addApt.TabIndex = 3;
            this.btn_addApt.Text = "Добавить";
            this.btn_addApt.UseVisualStyleBackColor = true;
            this.btn_addApt.Click += new System.EventHandler(this.btn_addApt_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_User.Location = new System.Drawing.Point(16, 16);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(208, 24);
            this.lbl_User.TabIndex = 4;
            // 
            // lstBx_mClntList
            // 
            this.lstBx_mClntList.FormattingEnabled = true;
            this.lstBx_mClntList.HorizontalScrollbar = true;
            this.lstBx_mClntList.Location = new System.Drawing.Point(304, 184);
            this.lstBx_mClntList.Name = "lstBx_mClntList";
            this.lstBx_mClntList.Size = new System.Drawing.Size(464, 95);
            this.lstBx_mClntList.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список клиентов";
            // 
            // btn_mClntList
            // 
            this.btn_mClntList.Location = new System.Drawing.Point(688, 144);
            this.btn_mClntList.Name = "btn_mClntList";
            this.btn_mClntList.Size = new System.Drawing.Size(75, 32);
            this.btn_mClntList.TabIndex = 7;
            this.btn_mClntList.Text = "Обновить";
            this.btn_mClntList.UseVisualStyleBackColor = true;
            this.btn_mClntList.Click += new System.EventHandler(this.btn_mClntList_Click);
            // 
            // mngrPnl
            // 
            this.mngrPnl.Controls.Add(this.btn_mExit);
            this.mngrPnl.Controls.Add(this.btn_appApprove);
            this.mngrPnl.Controls.Add(this.btn_mAppList);
            this.mngrPnl.Controls.Add(this.label2);
            this.mngrPnl.Controls.Add(this.lstBx_mAppl);
            this.mngrPnl.Controls.Add(this.btn_blockClt);
            this.mngrPnl.Controls.Add(this.lbl_Desc);
            this.mngrPnl.Controls.Add(this.lbl_Price);
            this.mngrPnl.Controls.Add(this.lbl_numOfRooms);
            this.mngrPnl.Controls.Add(this.lbl_Size);
            this.mngrPnl.Controls.Add(this.lbl_Address);
            this.mngrPnl.Controls.Add(this.txtBx_Desc);
            this.mngrPnl.Controls.Add(this.txtBx_Price);
            this.mngrPnl.Controls.Add(this.txtBx_numOfRooms);
            this.mngrPnl.Controls.Add(this.txtBx_Size);
            this.mngrPnl.Controls.Add(this.txtBx_Address);
            this.mngrPnl.Controls.Add(this.btn_mClntList);
            this.mngrPnl.Controls.Add(this.lstBx_mClntList);
            this.mngrPnl.Controls.Add(this.lbl_mApt);
            this.mngrPnl.Controls.Add(this.label1);
            this.mngrPnl.Controls.Add(this.lstBx_mAptView);
            this.mngrPnl.Controls.Add(this.btn_addApt);
            this.mngrPnl.Controls.Add(this.btn_mAptList);
            this.mngrPnl.Location = new System.Drawing.Point(16, 48);
            this.mngrPnl.Name = "mngrPnl";
            this.mngrPnl.Size = new System.Drawing.Size(768, 584);
            this.mngrPnl.TabIndex = 8;
            // 
            // btn_mExit
            // 
            this.btn_mExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_mExit.Location = new System.Drawing.Point(8, 544);
            this.btn_mExit.Name = "btn_mExit";
            this.btn_mExit.Size = new System.Drawing.Size(75, 32);
            this.btn_mExit.TabIndex = 26;
            this.btn_mExit.Text = "Выйти";
            this.btn_mExit.UseVisualStyleBackColor = true;
            this.btn_mExit.Click += new System.EventHandler(this.btn_mExit_Click);
            // 
            // btn_appApprove
            // 
            this.btn_appApprove.Location = new System.Drawing.Point(592, 288);
            this.btn_appApprove.Name = "btn_appApprove";
            this.btn_appApprove.Size = new System.Drawing.Size(80, 32);
            this.btn_appApprove.TabIndex = 25;
            this.btn_appApprove.Text = "Одобрить";
            this.btn_appApprove.UseVisualStyleBackColor = true;
            this.btn_appApprove.Click += new System.EventHandler(this.btn_appApprove_Click);
            // 
            // btn_mAppList
            // 
            this.btn_mAppList.Location = new System.Drawing.Point(688, 288);
            this.btn_mAppList.Name = "btn_mAppList";
            this.btn_mAppList.Size = new System.Drawing.Size(75, 32);
            this.btn_mAppList.TabIndex = 24;
            this.btn_mAppList.Text = "Обновить";
            this.btn_mAppList.UseVisualStyleBackColor = true;
            this.btn_mAppList.Click += new System.EventHandler(this.btn_mAppList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Список заявок";
            // 
            // lstBx_mAppl
            // 
            this.lstBx_mAppl.FormattingEnabled = true;
            this.lstBx_mAppl.HorizontalScrollbar = true;
            this.lstBx_mAppl.Location = new System.Drawing.Point(304, 328);
            this.lstBx_mAppl.Name = "lstBx_mAppl";
            this.lstBx_mAppl.Size = new System.Drawing.Size(464, 95);
            this.lstBx_mAppl.TabIndex = 22;
            // 
            // btn_blockClt
            // 
            this.btn_blockClt.Location = new System.Drawing.Point(568, 144);
            this.btn_blockClt.Name = "btn_blockClt";
            this.btn_blockClt.Size = new System.Drawing.Size(107, 32);
            this.btn_blockClt.TabIndex = 21;
            this.btn_blockClt.Text = "Заблокировать";
            this.btn_blockClt.UseVisualStyleBackColor = true;
            this.btn_blockClt.Click += new System.EventHandler(this.btn_blockClt_Click);
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Desc.Location = new System.Drawing.Point(0, 296);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(74, 17);
            this.lbl_Desc.TabIndex = 20;
            this.lbl_Desc.Text = "Описание";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Price.Location = new System.Drawing.Point(0, 264);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(191, 17);
            this.lbl_Price.TabIndex = 19;
            this.lbl_Price.Text = "Стоимость аренды за сутки";
            // 
            // lbl_numOfRooms
            // 
            this.lbl_numOfRooms.AutoSize = true;
            this.lbl_numOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_numOfRooms.Location = new System.Drawing.Point(0, 232);
            this.lbl_numOfRooms.Name = "lbl_numOfRooms";
            this.lbl_numOfRooms.Size = new System.Drawing.Size(137, 17);
            this.lbl_numOfRooms.TabIndex = 18;
            this.lbl_numOfRooms.Text = "Количество комнат";
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Size.Location = new System.Drawing.Point(0, 200);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(68, 17);
            this.lbl_Size.TabIndex = 17;
            this.lbl_Size.Text = "Площадь";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Address.Location = new System.Drawing.Point(0, 144);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(48, 17);
            this.lbl_Address.TabIndex = 16;
            this.lbl_Address.Text = "Адрес";
            // 
            // txtBx_Desc
            // 
            this.txtBx_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_Desc.Location = new System.Drawing.Point(0, 328);
            this.txtBx_Desc.Multiline = true;
            this.txtBx_Desc.Name = "txtBx_Desc";
            this.txtBx_Desc.Size = new System.Drawing.Size(288, 96);
            this.txtBx_Desc.TabIndex = 15;
            // 
            // txtBx_Price
            // 
            this.txtBx_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_Price.Location = new System.Drawing.Point(192, 264);
            this.txtBx_Price.Name = "txtBx_Price";
            this.txtBx_Price.Size = new System.Drawing.Size(96, 23);
            this.txtBx_Price.TabIndex = 14;
            // 
            // txtBx_numOfRooms
            // 
            this.txtBx_numOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_numOfRooms.Location = new System.Drawing.Point(144, 232);
            this.txtBx_numOfRooms.Name = "txtBx_numOfRooms";
            this.txtBx_numOfRooms.Size = new System.Drawing.Size(100, 23);
            this.txtBx_numOfRooms.TabIndex = 13;
            // 
            // txtBx_Size
            // 
            this.txtBx_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_Size.Location = new System.Drawing.Point(72, 200);
            this.txtBx_Size.Name = "txtBx_Size";
            this.txtBx_Size.Size = new System.Drawing.Size(100, 23);
            this.txtBx_Size.TabIndex = 12;
            // 
            // txtBx_Address
            // 
            this.txtBx_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_Address.Location = new System.Drawing.Point(0, 168);
            this.txtBx_Address.Name = "txtBx_Address";
            this.txtBx_Address.Size = new System.Drawing.Size(288, 23);
            this.txtBx_Address.TabIndex = 11;
            // 
            // clntPnl
            // 
            this.clntPnl.Controls.Add(this.btn_viewAgrmt);
            this.clntPnl.Controls.Add(this.Agrmnt);
            this.clntPnl.Controls.Add(this.lbl_Agrmnt);
            this.clntPnl.Controls.Add(this.lbl_appComm);
            this.clntPnl.Controls.Add(this.txtBx_appComm);
            this.clntPnl.Controls.Add(this.btn_Rent);
            this.clntPnl.Controls.Add(this.btn_cApp);
            this.clntPnl.Controls.Add(this.lbl_cApp);
            this.clntPnl.Controls.Add(this.lstBx_cAppl);
            this.clntPnl.Controls.Add(this.btn_RateAsmt);
            this.clntPnl.Controls.Add(this.btn_cAptList);
            this.clntPnl.Controls.Add(this.txtBx_Rate);
            this.clntPnl.Controls.Add(this.btn_cExit);
            this.clntPnl.Controls.Add(this.lbl_cApt);
            this.clntPnl.Controls.Add(this.lstBx_cAptView);
            this.clntPnl.Location = new System.Drawing.Point(16, 48);
            this.clntPnl.Name = "clntPnl";
            this.clntPnl.Size = new System.Drawing.Size(768, 584);
            this.clntPnl.TabIndex = 9;
            // 
            // btn_viewAgrmt
            // 
            this.btn_viewAgrmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_viewAgrmt.Location = new System.Drawing.Point(592, 200);
            this.btn_viewAgrmt.Name = "btn_viewAgrmt";
            this.btn_viewAgrmt.Size = new System.Drawing.Size(83, 48);
            this.btn_viewAgrmt.TabIndex = 40;
            this.btn_viewAgrmt.Text = "Посмотреть\r\nдоговор";
            this.btn_viewAgrmt.UseVisualStyleBackColor = true;
            this.btn_viewAgrmt.Click += new System.EventHandler(this.btn_viewAgrmt_Click);
            // 
            // Agrmnt
            // 
            this.Agrmnt.Location = new System.Drawing.Point(0, 392);
            this.Agrmnt.Name = "Agrmnt";
            this.Agrmnt.Size = new System.Drawing.Size(768, 136);
            this.Agrmnt.TabIndex = 39;
            // 
            // lbl_Agrmnt
            // 
            this.lbl_Agrmnt.AutoSize = true;
            this.lbl_Agrmnt.Location = new System.Drawing.Point(0, 368);
            this.lbl_Agrmnt.Name = "lbl_Agrmnt";
            this.lbl_Agrmnt.Size = new System.Drawing.Size(51, 13);
            this.lbl_Agrmnt.TabIndex = 38;
            this.lbl_Agrmnt.Text = "Договор";
            // 
            // lbl_appComm
            // 
            this.lbl_appComm.AutoSize = true;
            this.lbl_appComm.Location = new System.Drawing.Point(0, 152);
            this.lbl_appComm.Name = "lbl_appComm";
            this.lbl_appComm.Size = new System.Drawing.Size(125, 13);
            this.lbl_appComm.TabIndex = 37;
            this.lbl_appComm.Text = "Комментарий к заявке";
            // 
            // txtBx_appComm
            // 
            this.txtBx_appComm.Location = new System.Drawing.Point(0, 168);
            this.txtBx_appComm.Name = "txtBx_appComm";
            this.txtBx_appComm.Size = new System.Drawing.Size(672, 20);
            this.txtBx_appComm.TabIndex = 36;
            // 
            // btn_Rent
            // 
            this.btn_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Rent.Location = new System.Drawing.Point(680, 152);
            this.btn_Rent.Name = "btn_Rent";
            this.btn_Rent.Size = new System.Drawing.Size(80, 36);
            this.btn_Rent.TabIndex = 35;
            this.btn_Rent.Text = "Заявка на аренду";
            this.btn_Rent.UseVisualStyleBackColor = true;
            this.btn_Rent.Click += new System.EventHandler(this.btn_Rent_Click);
            // 
            // btn_cApp
            // 
            this.btn_cApp.Location = new System.Drawing.Point(688, 208);
            this.btn_cApp.Name = "btn_cApp";
            this.btn_cApp.Size = new System.Drawing.Size(75, 32);
            this.btn_cApp.TabIndex = 34;
            this.btn_cApp.Text = "Обновить";
            this.btn_cApp.UseVisualStyleBackColor = true;
            this.btn_cApp.Click += new System.EventHandler(this.btn_cApp_Click);
            // 
            // lbl_cApp
            // 
            this.lbl_cApp.AutoSize = true;
            this.lbl_cApp.Location = new System.Drawing.Point(0, 232);
            this.lbl_cApp.Name = "lbl_cApp";
            this.lbl_cApp.Size = new System.Drawing.Size(83, 13);
            this.lbl_cApp.TabIndex = 33;
            this.lbl_cApp.Text = "Список заявок";
            // 
            // lstBx_cAppl
            // 
            this.lstBx_cAppl.FormattingEnabled = true;
            this.lstBx_cAppl.HorizontalScrollbar = true;
            this.lstBx_cAppl.Location = new System.Drawing.Point(0, 256);
            this.lstBx_cAppl.Name = "lstBx_cAppl";
            this.lstBx_cAppl.Size = new System.Drawing.Size(768, 95);
            this.lstBx_cAppl.TabIndex = 32;
            // 
            // btn_RateAsmt
            // 
            this.btn_RateAsmt.Location = new System.Drawing.Point(600, 0);
            this.btn_RateAsmt.Name = "btn_RateAsmt";
            this.btn_RateAsmt.Size = new System.Drawing.Size(72, 32);
            this.btn_RateAsmt.TabIndex = 31;
            this.btn_RateAsmt.Text = "Оценить";
            this.btn_RateAsmt.UseVisualStyleBackColor = true;
            this.btn_RateAsmt.Click += new System.EventHandler(this.btn_RateAsmt_Click);
            // 
            // btn_cAptList
            // 
            this.btn_cAptList.Location = new System.Drawing.Point(688, 0);
            this.btn_cAptList.Name = "btn_cAptList";
            this.btn_cAptList.Size = new System.Drawing.Size(75, 32);
            this.btn_cAptList.TabIndex = 30;
            this.btn_cAptList.Text = "Обновить";
            this.btn_cAptList.UseVisualStyleBackColor = true;
            this.btn_cAptList.Click += new System.EventHandler(this.btn_cAptList_Click_1);
            // 
            // txtBx_Rate
            // 
            this.txtBx_Rate.Location = new System.Drawing.Point(528, 8);
            this.txtBx_Rate.Name = "txtBx_Rate";
            this.txtBx_Rate.Size = new System.Drawing.Size(64, 20);
            this.txtBx_Rate.TabIndex = 29;
            this.txtBx_Rate.TextChanged += new System.EventHandler(this.txtBx_Rate_TextChanged);
            // 
            // btn_cExit
            // 
            this.btn_cExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cExit.Location = new System.Drawing.Point(8, 544);
            this.btn_cExit.Name = "btn_cExit";
            this.btn_cExit.Size = new System.Drawing.Size(75, 32);
            this.btn_cExit.TabIndex = 27;
            this.btn_cExit.Text = "Выйти";
            this.btn_cExit.UseVisualStyleBackColor = true;
            this.btn_cExit.Click += new System.EventHandler(this.btn_cExit_Click);
            // 
            // lbl_cApt
            // 
            this.lbl_cApt.AutoSize = true;
            this.lbl_cApt.Location = new System.Drawing.Point(0, 16);
            this.lbl_cApt.Name = "lbl_cApt";
            this.lbl_cApt.Size = new System.Drawing.Size(88, 13);
            this.lbl_cApt.TabIndex = 4;
            this.lbl_cApt.Text = "Список квартир";
            // 
            // lstBx_cAptView
            // 
            this.lstBx_cAptView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstBx_cAptView.FormattingEnabled = true;
            this.lstBx_cAptView.HorizontalScrollbar = true;
            this.lstBx_cAptView.Location = new System.Drawing.Point(0, 40);
            this.lstBx_cAptView.Name = "lstBx_cAptView";
            this.lstBx_cAptView.Size = new System.Drawing.Size(768, 108);
            this.lstBx_cAptView.TabIndex = 3;
            // 
            // DealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 640);
            this.Controls.Add(this.clntPnl);
            this.Controls.Add(this.mngrPnl);
            this.Controls.Add(this.lbl_User);
            this.Name = "DealForm";
            this.Text = "Агентство по аренде квартир \"Уголок\"";
            this.Load += new System.EventHandler(this.DealForm_Load);
            this.mngrPnl.ResumeLayout(false);
            this.mngrPnl.PerformLayout();
            this.clntPnl.ResumeLayout(false);
            this.clntPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBx_mAptView;
        private System.Windows.Forms.Label lbl_mApt;
        private System.Windows.Forms.Button btn_mAptList;
        private System.Windows.Forms.Button btn_addApt;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.ListBox lstBx_mClntList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mClntList;
        private System.Windows.Forms.Panel mngrPnl;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_numOfRooms;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txtBx_Desc;
        private System.Windows.Forms.TextBox txtBx_Price;
        private System.Windows.Forms.TextBox txtBx_numOfRooms;
        private System.Windows.Forms.TextBox txtBx_Size;
        private System.Windows.Forms.TextBox txtBx_Address;
        private System.Windows.Forms.Button btn_blockClt;
        private System.Windows.Forms.Button btn_appApprove;
        private System.Windows.Forms.Button btn_mAppList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBx_mAppl;
        private System.Windows.Forms.Button btn_mExit;
        private System.Windows.Forms.Panel clntPnl;
        private System.Windows.Forms.Label lbl_cApt;
        private System.Windows.Forms.ListBox lstBx_cAptView;
        private System.Windows.Forms.Button btn_cExit;
        private System.Windows.Forms.TextBox txtBx_Rate;
        private System.Windows.Forms.Button btn_RateAsmt;
        private System.Windows.Forms.Button btn_cAptList;
        private System.Windows.Forms.ListBox lstBx_cAppl;
        private System.Windows.Forms.Button btn_cApp;
        private System.Windows.Forms.Label lbl_cApp;
        private System.Windows.Forms.Button btn_Rent;
        private System.Windows.Forms.Label lbl_appComm;
        private System.Windows.Forms.TextBox txtBx_appComm;
        private System.Windows.Forms.Label lbl_Agrmnt;
        private System.Windows.Forms.Label Agrmnt;
        private System.Windows.Forms.Button btn_viewAgrmt;
    }
}