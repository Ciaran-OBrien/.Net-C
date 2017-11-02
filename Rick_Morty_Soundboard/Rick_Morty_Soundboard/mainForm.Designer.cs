namespace Rick_Morty_Soundboard
{
    partial class mainForm
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
            this.lickButton = new System.Windows.Forms.Button();
            this.taffyButton = new System.Windows.Forms.Button();
            this.wubbaButton = new System.Windows.Forms.Button();
            this.grassButton = new System.Windows.Forms.Button();
            this.burgerButton = new System.Windows.Forms.Button();
            //this.aidsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lickButton
            // 
            this.lickButton.Location = new System.Drawing.Point(136, 623);
            this.lickButton.Name = "lickButton";
            this.lickButton.Size = new System.Drawing.Size(335, 56);
            this.lickButton.TabIndex = 0;
            this.lickButton.Text = "Lick Lick Lick";
            this.lickButton.UseVisualStyleBackColor = true;
            this.lickButton.Click += new System.EventHandler(this.lickButton_Click);
            // 
            // taffyButton
            // 
            this.taffyButton.Location = new System.Drawing.Point(620, 221);
            this.taffyButton.Name = "taffyButton";
            this.taffyButton.Size = new System.Drawing.Size(335, 56);
            this.taffyButton.TabIndex = 5;
            this.taffyButton.Text = "Ticky Taffy";
            this.taffyButton.UseVisualStyleBackColor = true;
            this.taffyButton.Click += new System.EventHandler(this.taffyButton_Click);
            // 
            // wubbaButton
            // 
            this.wubbaButton.Location = new System.Drawing.Point(1161, 221);
            this.wubbaButton.Name = "wubbaButton";
            this.wubbaButton.Size = new System.Drawing.Size(335, 56);
            this.wubbaButton.TabIndex = 4;
            this.wubbaButton.Text = "Wubba";
            this.wubbaButton.UseVisualStyleBackColor = true;
            this.wubbaButton.Click += new System.EventHandler(this.wubbaButton_Click);
            // 
            // grassButton
            // 
            this.grassButton.Location = new System.Drawing.Point(1161, 623);
            this.grassButton.Name = "grassButton";
            this.grassButton.Size = new System.Drawing.Size(335, 56);
            this.grassButton.TabIndex = 1;
            this.grassButton.Text = "Graaaaaaas";
            this.grassButton.UseVisualStyleBackColor = true;
            this.grassButton.Click += new System.EventHandler(this.grassButton_Click);
            // 
            // burgerButton
            // 
            this.burgerButton.Location = new System.Drawing.Point(620, 623);
            this.burgerButton.Name = "burgerButton";
            this.burgerButton.Size = new System.Drawing.Size(335, 56);
            this.burgerButton.TabIndex = 2;
            this.burgerButton.Text = "Burger Time";
            this.burgerButton.UseVisualStyleBackColor = true;
            this.burgerButton.Click += new System.EventHandler(this.burgerButton_Click);
            // 
            // aidsButton
            // 
            /*
            this.aidsButton.Location = new System.Drawing.Point(136, 221);
            this.aidsButton.Name = "aidsButton";
            this.aidsButton.Size = new System.Drawing.Size(335, 56);
            this.aidsButton.TabIndex = 3;
            this.aidsButton.Text = "Aids";
            this.aidsButton.UseVisualStyleBackColor = true;
            //this.aidsButton.Click += new System.EventHandler(this.aidsButton_Click);*/

            // 
            // mainForm
            // 
            this.BackgroundImage = global::Rick_Morty_Soundboard.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1574, 939);
            this.Controls.Add(this.lickButton);
            this.Controls.Add(this.taffyButton);
            this.Controls.Add(this.wubbaButton);
            this.Controls.Add(this.grassButton);
            this.Controls.Add(this.burgerButton);
            //this.Controls.Add(this.aidsButton);
            this.Name = "mainForm";
            this.Text = "Rick and Morty Soundboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lickButton;
        private System.Windows.Forms.Button taffyButton;
        private System.Windows.Forms.Button wubbaButton;
        private System.Windows.Forms.Button grassButton;
        private System.Windows.Forms.Button burgerButton;
        

    }
}

