namespace NDP_PROJECT_1._0
{
   partial class Coop
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coop));
            this.grpBoxProductStrg = new System.Windows.Forms.GroupBox();
            this.lblGoatMilk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCowMilk = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDuckEgg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblChickenEgg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpMarket = new System.Windows.Forms.GroupBox();
            this.btnSellGoatMilk = new System.Windows.Forms.Button();
            this.btnSellCowMilk = new System.Windows.Forms.Button();
            this.btnSellDuckEgg = new System.Windows.Forms.Button();
            this.btnSellChickenEgg = new System.Windows.Forms.Button();
            this.grpBoxTime = new System.Windows.Forms.GroupBox();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.grpBoxCash = new System.Windows.Forms.GroupBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.grpBoxCoop = new System.Windows.Forms.GroupBox();
            this.btnFeedDuck = new System.Windows.Forms.Button();
            this.prgrsDuck = new System.Windows.Forms.ProgressBar();
            this.lblDuckStatus = new System.Windows.Forms.Label();
            this.picDuck = new System.Windows.Forms.PictureBox();
            this.btnFeedChicken = new System.Windows.Forms.Button();
            this.prgrsChicken = new System.Windows.Forms.ProgressBar();
            this.lblChickenStatus = new System.Windows.Forms.Label();
            this.picChicken = new System.Windows.Forms.PictureBox();
            this.grpBoxBarn = new System.Windows.Forms.GroupBox();
            this.btnFeedGoat = new System.Windows.Forms.Button();
            this.prgrsGoat = new System.Windows.Forms.ProgressBar();
            this.lblGoatStatus = new System.Windows.Forms.Label();
            this.picGoat = new System.Windows.Forms.PictureBox();
            this.btnFeedCow = new System.Windows.Forms.Button();
            this.prgrsCow = new System.Windows.Forms.ProgressBar();
            this.lblCowStatus = new System.Windows.Forms.Label();
            this.picCow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerChicken = new System.Windows.Forms.Timer(this.components);
            this.timerDuck = new System.Windows.Forms.Timer(this.components);
            this.timerCow = new System.Windows.Forms.Timer(this.components);
            this.timerGoat = new System.Windows.Forms.Timer(this.components);
            this.timerCowDeath = new System.Windows.Forms.Timer(this.components);
            this.timerChickenDeath = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timerDuckDeath = new System.Windows.Forms.Timer(this.components);
            this.timerGoatDeath = new System.Windows.Forms.Timer(this.components);
            this.grpBoxProductStrg.SuspendLayout();
            this.grpMarket.SuspendLayout();
            this.grpBoxTime.SuspendLayout();
            this.grpBoxCash.SuspendLayout();
            this.grpBoxCoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDuck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).BeginInit();
            this.grpBoxBarn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCow)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxProductStrg
            // 
            this.grpBoxProductStrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpBoxProductStrg.Controls.Add(this.lblGoatMilk);
            this.grpBoxProductStrg.Controls.Add(this.label5);
            this.grpBoxProductStrg.Controls.Add(this.lblCowMilk);
            this.grpBoxProductStrg.Controls.Add(this.label8);
            this.grpBoxProductStrg.Controls.Add(this.lblDuckEgg);
            this.grpBoxProductStrg.Controls.Add(this.label6);
            this.grpBoxProductStrg.Controls.Add(this.lblChickenEgg);
            this.grpBoxProductStrg.Controls.Add(this.label3);
            this.grpBoxProductStrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxProductStrg.ForeColor = System.Drawing.Color.Red;
            this.grpBoxProductStrg.Location = new System.Drawing.Point(12, 12);
            this.grpBoxProductStrg.Name = "grpBoxProductStrg";
            this.grpBoxProductStrg.Size = new System.Drawing.Size(427, 294);
            this.grpBoxProductStrg.TabIndex = 0;
            this.grpBoxProductStrg.TabStop = false;
            this.grpBoxProductStrg.Text = "Product Storage";
            // 
            // lblGoatMilk
            // 
            this.lblGoatMilk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblGoatMilk.Location = new System.Drawing.Point(222, 238);
            this.lblGoatMilk.Name = "lblGoatMilk";
            this.lblGoatMilk.Size = new System.Drawing.Size(205, 53);
            this.lblGoatMilk.TabIndex = 7;
            this.lblGoatMilk.Text = "0";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(222, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 53);
            this.label5.TabIndex = 6;
            this.label5.Text = "Goat Milk";
            // 
            // lblCowMilk
            // 
            this.lblCowMilk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCowMilk.Location = new System.Drawing.Point(222, 109);
            this.lblCowMilk.Name = "lblCowMilk";
            this.lblCowMilk.Size = new System.Drawing.Size(205, 53);
            this.lblCowMilk.TabIndex = 5;
            this.lblCowMilk.Text = "0";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(222, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 53);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cow Milk";
            // 
            // lblDuckEgg
            // 
            this.lblDuckEgg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblDuckEgg.Location = new System.Drawing.Point(6, 238);
            this.lblDuckEgg.Name = "lblDuckEgg";
            this.lblDuckEgg.Size = new System.Drawing.Size(205, 53);
            this.lblDuckEgg.TabIndex = 3;
            this.lblDuckEgg.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 53);
            this.label6.TabIndex = 2;
            this.label6.Text = "Duck Egg";
            // 
            // lblChickenEgg
            // 
            this.lblChickenEgg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblChickenEgg.Location = new System.Drawing.Point(6, 109);
            this.lblChickenEgg.Name = "lblChickenEgg";
            this.lblChickenEgg.Size = new System.Drawing.Size(205, 53);
            this.lblChickenEgg.TabIndex = 1;
            this.lblChickenEgg.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chicken Egg";
            // 
            // grpMarket
            // 
            this.grpMarket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpMarket.Controls.Add(this.btnSellGoatMilk);
            this.grpMarket.Controls.Add(this.btnSellCowMilk);
            this.grpMarket.Controls.Add(this.btnSellDuckEgg);
            this.grpMarket.Controls.Add(this.btnSellChickenEgg);
            this.grpMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMarket.ForeColor = System.Drawing.Color.Red;
            this.grpMarket.Location = new System.Drawing.Point(505, 12);
            this.grpMarket.Name = "grpMarket";
            this.grpMarket.Size = new System.Drawing.Size(427, 294);
            this.grpMarket.TabIndex = 1;
            this.grpMarket.TabStop = false;
            this.grpMarket.Text = "Market Place";
            // 
            // btnSellGoatMilk
            // 
            this.btnSellGoatMilk.Location = new System.Drawing.Point(26, 235);
            this.btnSellGoatMilk.Name = "btnSellGoatMilk";
            this.btnSellGoatMilk.Size = new System.Drawing.Size(382, 53);
            this.btnSellGoatMilk.TabIndex = 3;
            this.btnSellGoatMilk.Text = "Sell Goat Milk";
            this.btnSellGoatMilk.UseVisualStyleBackColor = true;
            this.btnSellGoatMilk.Click += new System.EventHandler(this.btnSellGoatMilk_Click);
            // 
            // btnSellCowMilk
            // 
            this.btnSellCowMilk.Location = new System.Drawing.Point(26, 171);
            this.btnSellCowMilk.Name = "btnSellCowMilk";
            this.btnSellCowMilk.Size = new System.Drawing.Size(382, 53);
            this.btnSellCowMilk.TabIndex = 2;
            this.btnSellCowMilk.Text = "Sell Cow Milk";
            this.btnSellCowMilk.UseVisualStyleBackColor = true;
            this.btnSellCowMilk.Click += new System.EventHandler(this.btnSellCowMilk_Click);
            // 
            // btnSellDuckEgg
            // 
            this.btnSellDuckEgg.Location = new System.Drawing.Point(26, 109);
            this.btnSellDuckEgg.Name = "btnSellDuckEgg";
            this.btnSellDuckEgg.Size = new System.Drawing.Size(382, 53);
            this.btnSellDuckEgg.TabIndex = 1;
            this.btnSellDuckEgg.Text = "Sell Duck Egg";
            this.btnSellDuckEgg.UseVisualStyleBackColor = true;
            this.btnSellDuckEgg.Click += new System.EventHandler(this.btnSellDuckEgg_Click);
            // 
            // btnSellChickenEgg
            // 
            this.btnSellChickenEgg.Location = new System.Drawing.Point(26, 47);
            this.btnSellChickenEgg.Name = "btnSellChickenEgg";
            this.btnSellChickenEgg.Size = new System.Drawing.Size(382, 53);
            this.btnSellChickenEgg.TabIndex = 0;
            this.btnSellChickenEgg.Text = "Sell Chicken Egg";
            this.btnSellChickenEgg.UseVisualStyleBackColor = true;
            this.btnSellChickenEgg.Click += new System.EventHandler(this.btnSellChickenEgg_Click);
            // 
            // grpBoxTime
            // 
            this.grpBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpBoxTime.Controls.Add(this.lblElapsedTime);
            this.grpBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxTime.ForeColor = System.Drawing.Color.Red;
            this.grpBoxTime.Location = new System.Drawing.Point(960, 12);
            this.grpBoxTime.Name = "grpBoxTime";
            this.grpBoxTime.Size = new System.Drawing.Size(200, 131);
            this.grpBoxTime.TabIndex = 2;
            this.grpBoxTime.TabStop = false;
            this.grpBoxTime.Text = "Elapsed Time";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblElapsedTime.Location = new System.Drawing.Point(19, 37);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(159, 78);
            this.lblElapsedTime.TabIndex = 0;
            this.lblElapsedTime.Text = "0 second";
            // 
            // grpBoxCash
            // 
            this.grpBoxCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpBoxCash.Controls.Add(this.lblCash);
            this.grpBoxCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxCash.ForeColor = System.Drawing.Color.Red;
            this.grpBoxCash.Location = new System.Drawing.Point(960, 183);
            this.grpBoxCash.Name = "grpBoxCash";
            this.grpBoxCash.Size = new System.Drawing.Size(200, 123);
            this.grpBoxCash.TabIndex = 3;
            this.grpBoxCash.TabStop = false;
            this.grpBoxCash.Text = "Cash Register";
            // 
            // lblCash
            // 
            this.lblCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCash.Location = new System.Drawing.Point(19, 40);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(147, 65);
            this.lblCash.TabIndex = 0;
            this.lblCash.Text = "0  $";
            // 
            // grpBoxCoop
            // 
            this.grpBoxCoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpBoxCoop.Controls.Add(this.btnFeedDuck);
            this.grpBoxCoop.Controls.Add(this.prgrsDuck);
            this.grpBoxCoop.Controls.Add(this.lblDuckStatus);
            this.grpBoxCoop.Controls.Add(this.picDuck);
            this.grpBoxCoop.Controls.Add(this.btnFeedChicken);
            this.grpBoxCoop.Controls.Add(this.prgrsChicken);
            this.grpBoxCoop.Controls.Add(this.lblChickenStatus);
            this.grpBoxCoop.Controls.Add(this.picChicken);
            this.grpBoxCoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxCoop.ForeColor = System.Drawing.Color.Red;
            this.grpBoxCoop.Location = new System.Drawing.Point(12, 345);
            this.grpBoxCoop.Name = "grpBoxCoop";
            this.grpBoxCoop.Size = new System.Drawing.Size(427, 335);
            this.grpBoxCoop.TabIndex = 4;
            this.grpBoxCoop.TabStop = false;
            this.grpBoxCoop.Text = "Coop";
            // 
            // btnFeedDuck
            // 
            this.btnFeedDuck.Location = new System.Drawing.Point(165, 270);
            this.btnFeedDuck.Name = "btnFeedDuck";
            this.btnFeedDuck.Size = new System.Drawing.Size(223, 41);
            this.btnFeedDuck.TabIndex = 7;
            this.btnFeedDuck.Text = "Feed";
            this.btnFeedDuck.UseVisualStyleBackColor = true;
            this.btnFeedDuck.Click += new System.EventHandler(this.btnFeedDuck_Click);
            // 
            // prgrsDuck
            // 
            this.prgrsDuck.Location = new System.Drawing.Point(165, 233);
            this.prgrsDuck.Name = "prgrsDuck";
            this.prgrsDuck.Size = new System.Drawing.Size(223, 31);
            this.prgrsDuck.TabIndex = 6;
            // 
            // lblDuckStatus
            // 
            this.lblDuckStatus.Location = new System.Drawing.Point(163, 197);
            this.lblDuckStatus.Name = "lblDuckStatus";
            this.lblDuckStatus.Size = new System.Drawing.Size(225, 33);
            this.lblDuckStatus.TabIndex = 5;
            this.lblDuckStatus.Text = "Alive";
            // 
            // picDuck
            // 
            this.picDuck.Image = ((System.Drawing.Image)(resources.GetObject("picDuck.Image")));
            this.picDuck.Location = new System.Drawing.Point(11, 197);
            this.picDuck.Name = "picDuck";
            this.picDuck.Size = new System.Drawing.Size(119, 115);
            this.picDuck.TabIndex = 4;
            this.picDuck.TabStop = false;
            // 
            // btnFeedChicken
            // 
            this.btnFeedChicken.Location = new System.Drawing.Point(165, 122);
            this.btnFeedChicken.Name = "btnFeedChicken";
            this.btnFeedChicken.Size = new System.Drawing.Size(223, 41);
            this.btnFeedChicken.TabIndex = 3;
            this.btnFeedChicken.Text = "Feed";
            this.btnFeedChicken.UseVisualStyleBackColor = true;
            this.btnFeedChicken.Click += new System.EventHandler(this.btnFeedChicken_Click);
            // 
            // prgrsChicken
            // 
            this.prgrsChicken.Location = new System.Drawing.Point(165, 85);
            this.prgrsChicken.Name = "prgrsChicken";
            this.prgrsChicken.Size = new System.Drawing.Size(223, 31);
            this.prgrsChicken.TabIndex = 2;
            // 
            // lblChickenStatus
            // 
            this.lblChickenStatus.Location = new System.Drawing.Point(163, 49);
            this.lblChickenStatus.Name = "lblChickenStatus";
            this.lblChickenStatus.Size = new System.Drawing.Size(225, 33);
            this.lblChickenStatus.TabIndex = 1;
            this.lblChickenStatus.Text = "Alive";
            // 
            // picChicken
            // 
            this.picChicken.Image = ((System.Drawing.Image)(resources.GetObject("picChicken.Image")));
            this.picChicken.Location = new System.Drawing.Point(11, 49);
            this.picChicken.Name = "picChicken";
            this.picChicken.Size = new System.Drawing.Size(116, 115);
            this.picChicken.TabIndex = 0;
            this.picChicken.TabStop = false;
            // 
            // grpBoxBarn
            // 
            this.grpBoxBarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpBoxBarn.Controls.Add(this.btnFeedGoat);
            this.grpBoxBarn.Controls.Add(this.prgrsGoat);
            this.grpBoxBarn.Controls.Add(this.lblGoatStatus);
            this.grpBoxBarn.Controls.Add(this.picGoat);
            this.grpBoxBarn.Controls.Add(this.btnFeedCow);
            this.grpBoxBarn.Controls.Add(this.prgrsCow);
            this.grpBoxBarn.Controls.Add(this.lblCowStatus);
            this.grpBoxBarn.Controls.Add(this.picCow);
            this.grpBoxBarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxBarn.ForeColor = System.Drawing.Color.Red;
            this.grpBoxBarn.Location = new System.Drawing.Point(505, 345);
            this.grpBoxBarn.Name = "grpBoxBarn";
            this.grpBoxBarn.Size = new System.Drawing.Size(655, 335);
            this.grpBoxBarn.TabIndex = 5;
            this.grpBoxBarn.TabStop = false;
            this.grpBoxBarn.Text = "Barn";
            // 
            // btnFeedGoat
            // 
            this.btnFeedGoat.Location = new System.Drawing.Point(248, 280);
            this.btnFeedGoat.Name = "btnFeedGoat";
            this.btnFeedGoat.Size = new System.Drawing.Size(335, 41);
            this.btnFeedGoat.TabIndex = 15;
            this.btnFeedGoat.Text = "Feed";
            this.btnFeedGoat.UseVisualStyleBackColor = true;
            this.btnFeedGoat.Click += new System.EventHandler(this.btnFeedGoat_Click);
            // 
            // prgrsGoat
            // 
            this.prgrsGoat.Location = new System.Drawing.Point(248, 243);
            this.prgrsGoat.Name = "prgrsGoat";
            this.prgrsGoat.Size = new System.Drawing.Size(335, 31);
            this.prgrsGoat.TabIndex = 14;
            // 
            // lblGoatStatus
            // 
            this.lblGoatStatus.Location = new System.Drawing.Point(243, 197);
            this.lblGoatStatus.Name = "lblGoatStatus";
            this.lblGoatStatus.Size = new System.Drawing.Size(340, 33);
            this.lblGoatStatus.TabIndex = 13;
            this.lblGoatStatus.Text = "Alive";
            // 
            // picGoat
            // 
            this.picGoat.Image = ((System.Drawing.Image)(resources.GetObject("picGoat.Image")));
            this.picGoat.Location = new System.Drawing.Point(26, 197);
            this.picGoat.Name = "picGoat";
            this.picGoat.Size = new System.Drawing.Size(173, 125);
            this.picGoat.TabIndex = 12;
            this.picGoat.TabStop = false;
            // 
            // btnFeedCow
            // 
            this.btnFeedCow.Location = new System.Drawing.Point(248, 122);
            this.btnFeedCow.Name = "btnFeedCow";
            this.btnFeedCow.Size = new System.Drawing.Size(335, 41);
            this.btnFeedCow.TabIndex = 11;
            this.btnFeedCow.Text = "Feed";
            this.btnFeedCow.UseVisualStyleBackColor = true;
            this.btnFeedCow.Click += new System.EventHandler(this.btnFeedCow_Click);
            // 
            // prgrsCow
            // 
            this.prgrsCow.Location = new System.Drawing.Point(248, 85);
            this.prgrsCow.Name = "prgrsCow";
            this.prgrsCow.Size = new System.Drawing.Size(335, 31);
            this.prgrsCow.TabIndex = 10;
            // 
            // lblCowStatus
            // 
            this.lblCowStatus.Location = new System.Drawing.Point(243, 39);
            this.lblCowStatus.Name = "lblCowStatus";
            this.lblCowStatus.Size = new System.Drawing.Size(340, 33);
            this.lblCowStatus.TabIndex = 9;
            this.lblCowStatus.Text = "Alive";
            // 
            // picCow
            // 
            this.picCow.Image = ((System.Drawing.Image)(resources.GetObject("picCow.Image")));
            this.picCow.Location = new System.Drawing.Point(26, 39);
            this.picCow.Name = "picCow";
            this.picCow.Size = new System.Drawing.Size(173, 125);
            this.picCow.TabIndex = 8;
            this.picCow.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerChicken
            // 
            this.timerChicken.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerDuck
            // 
            this.timerDuck.Tick += new System.EventHandler(this.timerDuck_Tick);
            // 
            // timerCow
            // 
            this.timerCow.Tick += new System.EventHandler(this.timerCow_Tick);
            // 
            // timerGoat
            // 
            this.timerGoat.Tick += new System.EventHandler(this.timerGoat_Tick);
            // 
            // timerCowDeath
            // 
            this.timerCowDeath.Enabled = true;
            this.timerCowDeath.Tick += new System.EventHandler(this.timerCowDeath_Tick);
            // 
            // timerChickenDeath
            // 
            this.timerChickenDeath.Enabled = true;
            this.timerChickenDeath.Tick += new System.EventHandler(this.timerChickenDeath_Tick);
            // 
            // timerDuckDeath
            // 
            this.timerDuckDeath.Enabled = true;
            this.timerDuckDeath.Tick += new System.EventHandler(this.timerDuckDeath_Tick);
            // 
            // timerGoatDeath
            // 
            this.timerGoatDeath.Enabled = true;
            this.timerGoatDeath.Tick += new System.EventHandler(this.timerGoatDeath_Tick);
            // 
            // Coop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.grpBoxBarn);
            this.Controls.Add(this.grpBoxCoop);
            this.Controls.Add(this.grpBoxCash);
            this.Controls.Add(this.grpBoxTime);
            this.Controls.Add(this.grpMarket);
            this.Controls.Add(this.grpBoxProductStrg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Coop";
            this.Text = "PROJECT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxProductStrg.ResumeLayout(false);
            this.grpMarket.ResumeLayout(false);
            this.grpBoxTime.ResumeLayout(false);
            this.grpBoxCash.ResumeLayout(false);
            this.grpBoxCoop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDuck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).EndInit();
            this.grpBoxBarn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxProductStrg;
        private System.Windows.Forms.Label lblGoatMilk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCowMilk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDuckEgg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblChickenEgg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpMarket;
        private System.Windows.Forms.GroupBox grpBoxTime;
        private System.Windows.Forms.GroupBox grpBoxCash;
        private System.Windows.Forms.GroupBox grpBoxCoop;
        private System.Windows.Forms.GroupBox grpBoxBarn;
        private System.Windows.Forms.Button btnSellGoatMilk;
        private System.Windows.Forms.Button btnSellCowMilk;
        private System.Windows.Forms.Button btnSellDuckEgg;
        private System.Windows.Forms.Button btnSellChickenEgg;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Button btnFeedDuck;
        private System.Windows.Forms.ProgressBar prgrsDuck;
        private System.Windows.Forms.Label lblDuckStatus;
        private System.Windows.Forms.PictureBox picDuck;
        private System.Windows.Forms.Button btnFeedChicken;
        private System.Windows.Forms.ProgressBar prgrsChicken;
        private System.Windows.Forms.Label lblChickenStatus;
        private System.Windows.Forms.PictureBox picChicken;
        private System.Windows.Forms.Button btnFeedGoat;
        private System.Windows.Forms.ProgressBar prgrsGoat;
        private System.Windows.Forms.Label lblGoatStatus;
        private System.Windows.Forms.PictureBox picGoat;
        private System.Windows.Forms.Button btnFeedCow;
        private System.Windows.Forms.ProgressBar prgrsCow;
        private System.Windows.Forms.Label lblCowStatus;
        private System.Windows.Forms.PictureBox picCow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerChicken;
        private System.Windows.Forms.Timer timerDuck;
        private System.Windows.Forms.Timer timerCow;
        private System.Windows.Forms.Timer timerGoat;
        private System.Windows.Forms.Timer timerCowDeath;
        private System.Windows.Forms.Timer timerChickenDeath;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timerDuckDeath;
        private System.Windows.Forms.Timer timerGoatDeath;
    }
}

