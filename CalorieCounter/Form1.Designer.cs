
namespace CalorieCounter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCaloriesText = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.picPear = new System.Windows.Forms.PictureBox();
            this.picOrange = new System.Windows.Forms.PictureBox();
            this.picBanana = new System.Windows.Forms.PictureBox();
            this.picApple = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaloriesText
            // 
            this.lblCaloriesText.AutoSize = true;
            this.lblCaloriesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesText.Location = new System.Drawing.Point(486, 39);
            this.lblCaloriesText.Name = "lblCaloriesText";
            this.lblCaloriesText.Size = new System.Drawing.Size(109, 17);
            this.lblCaloriesText.TabIndex = 1;
            this.lblCaloriesText.Text = "Total Calories";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalories.Location = new System.Drawing.Point(487, 67);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(106, 23);
            this.lblTotalCalories.TabIndex = 2;
            this.lblTotalCalories.Text = "0";
            this.lblTotalCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(503, 400);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(503, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainer.Controls.Add(this.picPear);
            this.pnlContainer.Controls.Add(this.picOrange);
            this.pnlContainer.Controls.Add(this.picBanana);
            this.pnlContainer.Controls.Add(this.picApple);
            this.pnlContainer.Location = new System.Drawing.Point(12, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(468, 462);
            this.pnlContainer.TabIndex = 5;
            // 
            // picPear
            // 
            this.picPear.Image = ((System.Drawing.Image)(resources.GetObject("picPear.Image")));
            this.picPear.Location = new System.Drawing.Point(232, 237);
            this.picPear.Name = "picPear";
            this.picPear.Size = new System.Drawing.Size(229, 218);
            this.picPear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPear.TabIndex = 3;
            this.picPear.TabStop = false;
            this.picPear.Click += new System.EventHandler(this.picPear_Click);
            // 
            // picOrange
            // 
            this.picOrange.Image = ((System.Drawing.Image)(resources.GetObject("picOrange.Image")));
            this.picOrange.Location = new System.Drawing.Point(3, 237);
            this.picOrange.Name = "picOrange";
            this.picOrange.Size = new System.Drawing.Size(223, 218);
            this.picOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrange.TabIndex = 2;
            this.picOrange.TabStop = false;
            this.picOrange.Click += new System.EventHandler(this.picOrange_Click);
            // 
            // picBanana
            // 
            this.picBanana.Image = ((System.Drawing.Image)(resources.GetObject("picBanana.Image")));
            this.picBanana.Location = new System.Drawing.Point(3, 3);
            this.picBanana.Name = "picBanana";
            this.picBanana.Size = new System.Drawing.Size(223, 228);
            this.picBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanana.TabIndex = 1;
            this.picBanana.TabStop = false;
            this.picBanana.Click += new System.EventHandler(this.picBanana_Click);
            // 
            // picApple
            // 
            this.picApple.Image = ((System.Drawing.Image)(resources.GetObject("picApple.Image")));
            this.picApple.Location = new System.Drawing.Point(232, 3);
            this.picApple.Name = "picApple";
            this.picApple.Size = new System.Drawing.Size(229, 228);
            this.picApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApple.TabIndex = 0;
            this.picApple.TabStop = false;
            this.picApple.Click += new System.EventHandler(this.picApple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 495);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.lblCaloriesText);
            this.Name = "Form1";
            this.Text = "Calorie Counter";
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCaloriesText;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox picPear;
        private System.Windows.Forms.PictureBox picOrange;
        private System.Windows.Forms.PictureBox picBanana;
        private System.Windows.Forms.PictureBox picApple;
    }
}

