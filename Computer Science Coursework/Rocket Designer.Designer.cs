namespace Computer_Science_Coursework
{
    partial class Rocket_Designer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rocket_Designer));
            createStageButton = new Button();
            enginesGroupBox = new GroupBox();
            raptorButton = new Button();
            le7Button = new Button();
            rs25Button = new Button();
            numEnginesLabel = new Label();
            numEnginesNumericUpDown = new NumericUpDown();
            f1Button = new Button();
            rd180Button = new Button();
            stagesGroupBox = new GroupBox();
            stage2Button = new RadioButton();
            stage1Button = new RadioButton();
            fuelTankGroupbox = new GroupBox();
            extraWideGroupBox = new GroupBox();
            fuelTank13Button = new Button();
            fuelTank14Button = new Button();
            fuelTank12Button = new Button();
            wideGroupBox = new GroupBox();
            fuelTank10Button = new Button();
            fuelTank11Button = new Button();
            fuelTank9Button = new Button();
            midGroupBox = new GroupBox();
            fuelTank7Button = new Button();
            fuelTank8Button = new Button();
            fuelTank6Button = new Button();
            thinGroupBox = new GroupBox();
            fuelTank4Button = new Button();
            fuelTank5Button = new Button();
            fuelTank3Button = new Button();
            extraThinGroupBox = new GroupBox();
            fuelTank1Button = new Button();
            fuelTank2Button = new Button();
            fuelTank0Button = new Button();
            fuelTankPic1 = new PictureBox();
            fuelTankPic2 = new PictureBox();
            payloadPic = new PictureBox();
            payloadGroupBox = new GroupBox();
            largePayloadButton = new Button();
            smallPayloadButton = new Button();
            extraLargePayloadButton = new Button();
            mediumPayloadButton = new Button();
            extraSmallPayloadButton = new Button();
            enginePic2 = new PictureBox();
            removeStageButton = new Button();
            launchButton = new Button();
            launchPictureBox = new PictureBox();
            enginePic1 = new PictureBox();
            launchTimer = new System.Windows.Forms.Timer(components);
            budgetLabel = new Label();
            rocketCostLabel = new Label();
            mainMenuButton = new Button();
            saveRocketButton = new Button();
            descriptionToolTip = new ToolTip(components);
            deleteRocketButton = new Button();
            enginesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEnginesNumericUpDown).BeginInit();
            stagesGroupBox.SuspendLayout();
            fuelTankGroupbox.SuspendLayout();
            extraWideGroupBox.SuspendLayout();
            wideGroupBox.SuspendLayout();
            midGroupBox.SuspendLayout();
            thinGroupBox.SuspendLayout();
            extraThinGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fuelTankPic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fuelTankPic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)payloadPic).BeginInit();
            payloadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enginePic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)launchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enginePic1).BeginInit();
            SuspendLayout();
            // 
            // createStageButton
            // 
            createStageButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createStageButton.Location = new Point(1698, 860);
            createStageButton.Margin = new Padding(1);
            createStageButton.Name = "createStageButton";
            createStageButton.Size = new Size(85, 65);
            createStageButton.TabIndex = 0;
            createStageButton.Text = "Create New Stage";
            createStageButton.UseVisualStyleBackColor = true;
            createStageButton.Click += createStageButton_Click;
            // 
            // enginesGroupBox
            // 
            enginesGroupBox.Controls.Add(raptorButton);
            enginesGroupBox.Controls.Add(le7Button);
            enginesGroupBox.Controls.Add(rs25Button);
            enginesGroupBox.Controls.Add(numEnginesLabel);
            enginesGroupBox.Controls.Add(numEnginesNumericUpDown);
            enginesGroupBox.Controls.Add(f1Button);
            enginesGroupBox.Controls.Add(rd180Button);
            enginesGroupBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enginesGroupBox.Location = new Point(18, 282);
            enginesGroupBox.Margin = new Padding(1);
            enginesGroupBox.Name = "enginesGroupBox";
            enginesGroupBox.Padding = new Padding(1);
            enginesGroupBox.Size = new Size(290, 216);
            enginesGroupBox.TabIndex = 1;
            enginesGroupBox.TabStop = false;
            enginesGroupBox.Text = "Engines";
            // 
            // raptorButton
            // 
            raptorButton.Location = new Point(152, 84);
            raptorButton.Margin = new Padding(1);
            raptorButton.Name = "raptorButton";
            raptorButton.Size = new Size(85, 65);
            raptorButton.TabIndex = 8;
            raptorButton.Text = "Raptor";
            raptorButton.UseVisualStyleBackColor = true;
            raptorButton.Click += raptorButton_Click;
            // 
            // le7Button
            // 
            le7Button.Location = new Point(65, 84);
            le7Button.Margin = new Padding(1);
            le7Button.Name = "le7Button";
            le7Button.Size = new Size(85, 65);
            le7Button.TabIndex = 7;
            le7Button.Text = "LE7";
            le7Button.UseVisualStyleBackColor = true;
            le7Button.Click += le7Button_Click;
            // 
            // rs25Button
            // 
            rs25Button.Location = new Point(190, 17);
            rs25Button.Margin = new Padding(1);
            rs25Button.Name = "rs25Button";
            rs25Button.Size = new Size(85, 65);
            rs25Button.TabIndex = 6;
            rs25Button.Text = "RS-25";
            rs25Button.UseVisualStyleBackColor = true;
            rs25Button.Click += rs25Button_Click;
            // 
            // numEnginesLabel
            // 
            numEnginesLabel.AutoSize = true;
            numEnginesLabel.Location = new Point(16, 179);
            numEnginesLabel.Name = "numEnginesLabel";
            numEnginesLabel.Size = new Size(131, 14);
            numEnginesLabel.TabIndex = 5;
            numEnginesLabel.Text = "Number of Engines:";
            // 
            // numEnginesNumericUpDown
            // 
            numEnginesNumericUpDown.Location = new Point(149, 175);
            numEnginesNumericUpDown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numEnginesNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numEnginesNumericUpDown.Name = "numEnginesNumericUpDown";
            numEnginesNumericUpDown.Size = new Size(120, 22);
            numEnginesNumericUpDown.TabIndex = 4;
            numEnginesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numEnginesNumericUpDown.ValueChanged += numEnginesNumericUpDown_ValueChanged;
            // 
            // f1Button
            // 
            f1Button.Location = new Point(103, 17);
            f1Button.Margin = new Padding(1);
            f1Button.Name = "f1Button";
            f1Button.Size = new Size(85, 65);
            f1Button.TabIndex = 3;
            f1Button.Text = "F1";
            f1Button.UseVisualStyleBackColor = true;
            f1Button.Click += f1Button_Click;
            // 
            // rd180Button
            // 
            rd180Button.Location = new Point(16, 17);
            rd180Button.Margin = new Padding(1);
            rd180Button.Name = "rd180Button";
            rd180Button.Size = new Size(85, 65);
            rd180Button.TabIndex = 0;
            rd180Button.Text = "RD-180";
            rd180Button.UseVisualStyleBackColor = true;
            rd180Button.Click += rd180Button_Click;
            // 
            // stagesGroupBox
            // 
            stagesGroupBox.Controls.Add(stage2Button);
            stagesGroupBox.Controls.Add(stage1Button);
            stagesGroupBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stagesGroupBox.Location = new Point(1791, 860);
            stagesGroupBox.Margin = new Padding(1);
            stagesGroupBox.Name = "stagesGroupBox";
            stagesGroupBox.Padding = new Padding(1);
            stagesGroupBox.Size = new Size(87, 65);
            stagesGroupBox.TabIndex = 3;
            stagesGroupBox.TabStop = false;
            stagesGroupBox.Text = "Stages";
            // 
            // stage2Button
            // 
            stage2Button.AutoSize = true;
            stage2Button.Location = new Point(11, 36);
            stage2Button.Margin = new Padding(1);
            stage2Button.Name = "stage2Button";
            stage2Button.Size = new Size(74, 18);
            stage2Button.TabIndex = 5;
            stage2Button.TabStop = true;
            stage2Button.Text = "Stage 2";
            stage2Button.UseVisualStyleBackColor = true;
            stage2Button.Visible = false;
            stage2Button.Click += stage2Button_Click;
            // 
            // stage1Button
            // 
            stage1Button.AutoSize = true;
            stage1Button.Location = new Point(11, 17);
            stage1Button.Margin = new Padding(1);
            stage1Button.Name = "stage1Button";
            stage1Button.Size = new Size(74, 18);
            stage1Button.TabIndex = 4;
            stage1Button.TabStop = true;
            stage1Button.Text = "Stage 1";
            stage1Button.UseVisualStyleBackColor = true;
            stage1Button.Visible = false;
            stage1Button.Click += stage1Button_Click;
            // 
            // fuelTankGroupbox
            // 
            fuelTankGroupbox.Controls.Add(extraWideGroupBox);
            fuelTankGroupbox.Controls.Add(wideGroupBox);
            fuelTankGroupbox.Controls.Add(midGroupBox);
            fuelTankGroupbox.Controls.Add(thinGroupBox);
            fuelTankGroupbox.Controls.Add(extraThinGroupBox);
            fuelTankGroupbox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fuelTankGroupbox.Location = new Point(18, 510);
            fuelTankGroupbox.Margin = new Padding(1);
            fuelTankGroupbox.Name = "fuelTankGroupbox";
            fuelTankGroupbox.Padding = new Padding(1);
            fuelTankGroupbox.Size = new Size(290, 519);
            fuelTankGroupbox.TabIndex = 7;
            fuelTankGroupbox.TabStop = false;
            fuelTankGroupbox.Text = "Fuel Tank";
            // 
            // extraWideGroupBox
            // 
            extraWideGroupBox.Controls.Add(fuelTank13Button);
            extraWideGroupBox.Controls.Add(fuelTank14Button);
            extraWideGroupBox.Controls.Add(fuelTank12Button);
            extraWideGroupBox.Location = new Point(1, 423);
            extraWideGroupBox.Name = "extraWideGroupBox";
            extraWideGroupBox.Size = new Size(300, 93);
            extraWideGroupBox.TabIndex = 4;
            extraWideGroupBox.TabStop = false;
            extraWideGroupBox.Text = "Extra Wide";
            // 
            // fuelTank13Button
            // 
            fuelTank13Button.Location = new Point(102, 21);
            fuelTank13Button.Name = "fuelTank13Button";
            fuelTank13Button.Size = new Size(85, 65);
            fuelTank13Button.TabIndex = 24;
            fuelTank13Button.Tag = "13";
            fuelTank13Button.Text = "Regular Tank";
            fuelTank13Button.UseVisualStyleBackColor = true;
            fuelTank13Button.Click += fuelTank13Button_Click;
            // 
            // fuelTank14Button
            // 
            fuelTank14Button.Location = new Point(193, 21);
            fuelTank14Button.Name = "fuelTank14Button";
            fuelTank14Button.Size = new Size(85, 65);
            fuelTank14Button.TabIndex = 23;
            fuelTank14Button.Tag = "14";
            fuelTank14Button.Text = "Tall Tank";
            fuelTank14Button.UseVisualStyleBackColor = true;
            fuelTank14Button.Click += fuelTank14Button_Click;
            // 
            // fuelTank12Button
            // 
            fuelTank12Button.Location = new Point(11, 21);
            fuelTank12Button.Name = "fuelTank12Button";
            fuelTank12Button.Size = new Size(85, 65);
            fuelTank12Button.TabIndex = 22;
            fuelTank12Button.Tag = "12";
            fuelTank12Button.Text = "Short Tank";
            fuelTank12Button.UseVisualStyleBackColor = true;
            fuelTank12Button.Click += fuelTank12Button_Click;
            // 
            // wideGroupBox
            // 
            wideGroupBox.Controls.Add(fuelTank10Button);
            wideGroupBox.Controls.Add(fuelTank11Button);
            wideGroupBox.Controls.Add(fuelTank9Button);
            wideGroupBox.Location = new Point(1, 324);
            wideGroupBox.Name = "wideGroupBox";
            wideGroupBox.Size = new Size(300, 93);
            wideGroupBox.TabIndex = 3;
            wideGroupBox.TabStop = false;
            wideGroupBox.Text = "Wide";
            // 
            // fuelTank10Button
            // 
            fuelTank10Button.Location = new Point(102, 22);
            fuelTank10Button.Name = "fuelTank10Button";
            fuelTank10Button.Size = new Size(85, 65);
            fuelTank10Button.TabIndex = 21;
            fuelTank10Button.Tag = "10";
            fuelTank10Button.Text = "Regular Tank";
            fuelTank10Button.UseVisualStyleBackColor = true;
            fuelTank10Button.Click += fuelTank10Button_Click;
            // 
            // fuelTank11Button
            // 
            fuelTank11Button.Location = new Point(193, 22);
            fuelTank11Button.Name = "fuelTank11Button";
            fuelTank11Button.Size = new Size(85, 65);
            fuelTank11Button.TabIndex = 20;
            fuelTank11Button.Tag = "11";
            fuelTank11Button.Text = "Tall Tank";
            fuelTank11Button.UseVisualStyleBackColor = true;
            fuelTank11Button.Click += fuelTank11Button_Click;
            // 
            // fuelTank9Button
            // 
            fuelTank9Button.Location = new Point(11, 22);
            fuelTank9Button.Name = "fuelTank9Button";
            fuelTank9Button.Size = new Size(85, 65);
            fuelTank9Button.TabIndex = 19;
            fuelTank9Button.Tag = "9";
            fuelTank9Button.Text = "Short Tank";
            fuelTank9Button.UseVisualStyleBackColor = true;
            fuelTank9Button.Click += fuelTank9Button_Click;
            // 
            // midGroupBox
            // 
            midGroupBox.Controls.Add(fuelTank7Button);
            midGroupBox.Controls.Add(fuelTank8Button);
            midGroupBox.Controls.Add(fuelTank6Button);
            midGroupBox.Location = new Point(1, 221);
            midGroupBox.Name = "midGroupBox";
            midGroupBox.Size = new Size(289, 93);
            midGroupBox.TabIndex = 2;
            midGroupBox.TabStop = false;
            midGroupBox.Text = "Mid";
            // 
            // fuelTank7Button
            // 
            fuelTank7Button.Location = new Point(102, 22);
            fuelTank7Button.Name = "fuelTank7Button";
            fuelTank7Button.Size = new Size(85, 65);
            fuelTank7Button.TabIndex = 21;
            fuelTank7Button.Tag = "7";
            fuelTank7Button.Text = "Regular Tank";
            fuelTank7Button.UseVisualStyleBackColor = true;
            fuelTank7Button.Click += fuelTank7Button_Click;
            // 
            // fuelTank8Button
            // 
            fuelTank8Button.Location = new Point(193, 22);
            fuelTank8Button.Name = "fuelTank8Button";
            fuelTank8Button.Size = new Size(85, 65);
            fuelTank8Button.TabIndex = 20;
            fuelTank8Button.Tag = "8";
            fuelTank8Button.Text = "Tall Tank";
            fuelTank8Button.UseVisualStyleBackColor = true;
            fuelTank8Button.Click += fuelTank8Button_Click;
            // 
            // fuelTank6Button
            // 
            fuelTank6Button.Location = new Point(11, 22);
            fuelTank6Button.Name = "fuelTank6Button";
            fuelTank6Button.Size = new Size(85, 65);
            fuelTank6Button.TabIndex = 19;
            fuelTank6Button.Tag = "6";
            fuelTank6Button.Text = "Short Tank";
            fuelTank6Button.UseVisualStyleBackColor = true;
            fuelTank6Button.Click += fuelTank6Button_Click;
            // 
            // thinGroupBox
            // 
            thinGroupBox.Controls.Add(fuelTank4Button);
            thinGroupBox.Controls.Add(fuelTank5Button);
            thinGroupBox.Controls.Add(fuelTank3Button);
            thinGroupBox.Location = new Point(1, 122);
            thinGroupBox.Name = "thinGroupBox";
            thinGroupBox.Size = new Size(289, 93);
            thinGroupBox.TabIndex = 1;
            thinGroupBox.TabStop = false;
            thinGroupBox.Text = "Thin";
            // 
            // fuelTank4Button
            // 
            fuelTank4Button.Location = new Point(102, 22);
            fuelTank4Button.Name = "fuelTank4Button";
            fuelTank4Button.Size = new Size(85, 65);
            fuelTank4Button.TabIndex = 18;
            fuelTank4Button.Tag = "4";
            fuelTank4Button.Text = "Regular Tank";
            fuelTank4Button.UseVisualStyleBackColor = true;
            fuelTank4Button.Click += fuelTank4Button_Click;
            // 
            // fuelTank5Button
            // 
            fuelTank5Button.Location = new Point(193, 22);
            fuelTank5Button.Name = "fuelTank5Button";
            fuelTank5Button.Size = new Size(85, 65);
            fuelTank5Button.TabIndex = 17;
            fuelTank5Button.Tag = "5";
            fuelTank5Button.Text = "Tall Tank";
            fuelTank5Button.UseVisualStyleBackColor = true;
            fuelTank5Button.Click += fuelTank5Button_Click;
            // 
            // fuelTank3Button
            // 
            fuelTank3Button.Location = new Point(11, 22);
            fuelTank3Button.Name = "fuelTank3Button";
            fuelTank3Button.Size = new Size(85, 65);
            fuelTank3Button.TabIndex = 16;
            fuelTank3Button.Tag = "3";
            fuelTank3Button.Text = "Short Tank";
            fuelTank3Button.UseVisualStyleBackColor = true;
            fuelTank3Button.Click += fuelTank3Button_Click;
            // 
            // extraThinGroupBox
            // 
            extraThinGroupBox.Controls.Add(fuelTank1Button);
            extraThinGroupBox.Controls.Add(fuelTank2Button);
            extraThinGroupBox.Controls.Add(fuelTank0Button);
            extraThinGroupBox.Location = new Point(1, 23);
            extraThinGroupBox.Name = "extraThinGroupBox";
            extraThinGroupBox.Size = new Size(289, 93);
            extraThinGroupBox.TabIndex = 0;
            extraThinGroupBox.TabStop = false;
            extraThinGroupBox.Text = "Extra Thin";
            // 
            // fuelTank1Button
            // 
            fuelTank1Button.Location = new Point(102, 22);
            fuelTank1Button.Name = "fuelTank1Button";
            fuelTank1Button.Size = new Size(85, 65);
            fuelTank1Button.TabIndex = 15;
            fuelTank1Button.Tag = "1";
            fuelTank1Button.Text = "Regular Tank";
            fuelTank1Button.UseVisualStyleBackColor = true;
            fuelTank1Button.Click += fuelTank1Button_Click;
            // 
            // fuelTank2Button
            // 
            fuelTank2Button.Location = new Point(193, 22);
            fuelTank2Button.Name = "fuelTank2Button";
            fuelTank2Button.Size = new Size(85, 65);
            fuelTank2Button.TabIndex = 14;
            fuelTank2Button.Tag = "2";
            fuelTank2Button.Text = "Tall Tank";
            fuelTank2Button.UseVisualStyleBackColor = true;
            fuelTank2Button.Click += fuelTank2Button_Click;
            // 
            // fuelTank0Button
            // 
            fuelTank0Button.Location = new Point(11, 22);
            fuelTank0Button.Name = "fuelTank0Button";
            fuelTank0Button.Size = new Size(85, 65);
            fuelTank0Button.TabIndex = 13;
            fuelTank0Button.Tag = "0";
            fuelTank0Button.Text = "Short Tank";
            fuelTank0Button.UseVisualStyleBackColor = true;
            fuelTank0Button.Click += fuelTank0Button_Click;
            // 
            // fuelTankPic1
            // 
            fuelTankPic1.Image = (Image)resources.GetObject("fuelTankPic1.Image");
            fuelTankPic1.Location = new Point(529, 747);
            fuelTankPic1.Margin = new Padding(1);
            fuelTankPic1.Name = "fuelTankPic1";
            fuelTankPic1.Size = new Size(50, 50);
            fuelTankPic1.SizeMode = PictureBoxSizeMode.StretchImage;
            fuelTankPic1.TabIndex = 8;
            fuelTankPic1.TabStop = false;
            // 
            // fuelTankPic2
            // 
            fuelTankPic2.Image = (Image)resources.GetObject("fuelTankPic2.Image");
            fuelTankPic2.Location = new Point(1157, 223);
            fuelTankPic2.Margin = new Padding(1);
            fuelTankPic2.Name = "fuelTankPic2";
            fuelTankPic2.Size = new Size(200, 300);
            fuelTankPic2.SizeMode = PictureBoxSizeMode.StretchImage;
            fuelTankPic2.TabIndex = 12;
            fuelTankPic2.TabStop = false;
            // 
            // payloadPic
            // 
            payloadPic.BackColor = Color.Transparent;
            payloadPic.BackgroundImageLayout = ImageLayout.None;
            payloadPic.Location = new Point(1007, 68);
            payloadPic.Name = "payloadPic";
            payloadPic.Size = new Size(179, 129);
            payloadPic.SizeMode = PictureBoxSizeMode.StretchImage;
            payloadPic.TabIndex = 13;
            payloadPic.TabStop = false;
            // 
            // payloadGroupBox
            // 
            payloadGroupBox.Controls.Add(largePayloadButton);
            payloadGroupBox.Controls.Add(smallPayloadButton);
            payloadGroupBox.Controls.Add(extraLargePayloadButton);
            payloadGroupBox.Controls.Add(mediumPayloadButton);
            payloadGroupBox.Controls.Add(extraSmallPayloadButton);
            payloadGroupBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payloadGroupBox.Location = new Point(18, 90);
            payloadGroupBox.Margin = new Padding(1);
            payloadGroupBox.Name = "payloadGroupBox";
            payloadGroupBox.Padding = new Padding(1);
            payloadGroupBox.Size = new Size(290, 180);
            payloadGroupBox.TabIndex = 5;
            payloadGroupBox.TabStop = false;
            payloadGroupBox.Text = "Payloads";
            // 
            // largePayloadButton
            // 
            largePayloadButton.Location = new Point(152, 94);
            largePayloadButton.Margin = new Padding(1);
            largePayloadButton.Name = "largePayloadButton";
            largePayloadButton.Size = new Size(85, 65);
            largePayloadButton.TabIndex = 13;
            largePayloadButton.Text = "Large";
            largePayloadButton.UseVisualStyleBackColor = true;
            largePayloadButton.Click += largePayloadButton_Click_1;
            // 
            // smallPayloadButton
            // 
            smallPayloadButton.Location = new Point(65, 94);
            smallPayloadButton.Margin = new Padding(1);
            smallPayloadButton.Name = "smallPayloadButton";
            smallPayloadButton.Size = new Size(85, 65);
            smallPayloadButton.TabIndex = 12;
            smallPayloadButton.Text = "Small (Crewed)";
            smallPayloadButton.UseVisualStyleBackColor = true;
            smallPayloadButton.Click += smallPayloadButton_Click_1;
            // 
            // extraLargePayloadButton
            // 
            extraLargePayloadButton.Location = new Point(190, 27);
            extraLargePayloadButton.Margin = new Padding(1);
            extraLargePayloadButton.Name = "extraLargePayloadButton";
            extraLargePayloadButton.Size = new Size(85, 65);
            extraLargePayloadButton.TabIndex = 11;
            extraLargePayloadButton.Text = "Extra Large";
            extraLargePayloadButton.UseVisualStyleBackColor = true;
            extraLargePayloadButton.Click += extraLargePayloadButton_Click;
            // 
            // mediumPayloadButton
            // 
            mediumPayloadButton.Location = new Point(103, 27);
            mediumPayloadButton.Margin = new Padding(1);
            mediumPayloadButton.Name = "mediumPayloadButton";
            mediumPayloadButton.Size = new Size(85, 65);
            mediumPayloadButton.TabIndex = 10;
            mediumPayloadButton.Text = "Medium (Crewed)";
            mediumPayloadButton.UseVisualStyleBackColor = true;
            mediumPayloadButton.Click += mediumPayloadButton_Click_1;
            // 
            // extraSmallPayloadButton
            // 
            extraSmallPayloadButton.Location = new Point(16, 27);
            extraSmallPayloadButton.Margin = new Padding(1);
            extraSmallPayloadButton.Name = "extraSmallPayloadButton";
            extraSmallPayloadButton.Size = new Size(85, 65);
            extraSmallPayloadButton.TabIndex = 9;
            extraSmallPayloadButton.Text = "Extra Small";
            extraSmallPayloadButton.UseVisualStyleBackColor = true;
            extraSmallPayloadButton.Click += extraSmallPayloadButton_Click_1;
            // 
            // enginePic2
            // 
            enginePic2.BackColor = Color.Transparent;
            enginePic2.Location = new Point(872, 282);
            enginePic2.Name = "enginePic2";
            enginePic2.Size = new Size(62, 78);
            enginePic2.TabIndex = 1;
            enginePic2.TabStop = false;
            // 
            // removeStageButton
            // 
            removeStageButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeStageButton.Location = new Point(1609, 860);
            removeStageButton.Name = "removeStageButton";
            removeStageButton.Size = new Size(85, 65);
            removeStageButton.TabIndex = 14;
            removeStageButton.Text = "Remove Stage";
            removeStageButton.UseVisualStyleBackColor = true;
            removeStageButton.Click += removeStageButton_Click;
            // 
            // launchButton
            // 
            launchButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            launchButton.Location = new Point(1602, 929);
            launchButton.Name = "launchButton";
            launchButton.Size = new Size(290, 100);
            launchButton.TabIndex = 15;
            launchButton.Text = "Launch";
            launchButton.UseVisualStyleBackColor = true;
            launchButton.Click += launchButton_Click;
            // 
            // launchPictureBox
            // 
            launchPictureBox.Image = (Image)resources.GetObject("launchPictureBox.Image");
            launchPictureBox.Location = new Point(474, 98);
            launchPictureBox.Name = "launchPictureBox";
            launchPictureBox.Size = new Size(251, 132);
            launchPictureBox.TabIndex = 16;
            launchPictureBox.TabStop = false;
            launchPictureBox.Visible = false;
            launchPictureBox.Paint += launchPictureBox_Paint;
            // 
            // enginePic1
            // 
            enginePic1.BackColor = Color.Transparent;
            enginePic1.Location = new Point(911, 484);
            enginePic1.Name = "enginePic1";
            enginePic1.Size = new Size(112, 142);
            enginePic1.TabIndex = 17;
            enginePic1.TabStop = false;
            // 
            // launchTimer
            // 
            launchTimer.Interval = 1500;
            launchTimer.Tick += launchTimer_Tick;
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            budgetLabel.Location = new Point(18, 12);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(117, 23);
            budgetLabel.TabIndex = 20;
            budgetLabel.Text = "Budget: £0";
            // 
            // rocketCostLabel
            // 
            rocketCostLabel.AutoSize = true;
            rocketCostLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rocketCostLabel.Location = new Point(19, 46);
            rocketCostLabel.Name = "rocketCostLabel";
            rocketCostLabel.Size = new Size(163, 23);
            rocketCostLabel.TabIndex = 21;
            rocketCostLabel.Text = "Rocket Cost: £0";
            // 
            // mainMenuButton
            // 
            mainMenuButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainMenuButton.Location = new Point(1842, 12);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(50, 50);
            mainMenuButton.TabIndex = 22;
            mainMenuButton.Text = "🏠";
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // saveRocketButton
            // 
            saveRocketButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveRocketButton.Location = new Point(1534, 933);
            saveRocketButton.Name = "saveRocketButton";
            saveRocketButton.Size = new Size(65, 47);
            saveRocketButton.TabIndex = 23;
            saveRocketButton.Text = "📂";
            saveRocketButton.UseVisualStyleBackColor = true;
            saveRocketButton.Click += saveRocketButton_Click;
            // 
            // deleteRocketButton
            // 
            deleteRocketButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteRocketButton.Location = new Point(1534, 982);
            deleteRocketButton.Name = "deleteRocketButton";
            deleteRocketButton.Size = new Size(65, 47);
            deleteRocketButton.TabIndex = 24;
            deleteRocketButton.Text = "🗑️";
            deleteRocketButton.UseVisualStyleBackColor = true;
            deleteRocketButton.Click += deleteRocketButton_Click;
            // 
            // Rocket_Designer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(deleteRocketButton);
            Controls.Add(saveRocketButton);
            Controls.Add(mainMenuButton);
            Controls.Add(createStageButton);
            Controls.Add(rocketCostLabel);
            Controls.Add(budgetLabel);
            Controls.Add(enginePic2);
            Controls.Add(enginePic1);
            Controls.Add(fuelTankPic2);
            Controls.Add(launchPictureBox);
            Controls.Add(fuelTankPic1);
            Controls.Add(payloadPic);
            Controls.Add(launchButton);
            Controls.Add(removeStageButton);
            Controls.Add(payloadGroupBox);
            Controls.Add(fuelTankGroupbox);
            Controls.Add(stagesGroupBox);
            Controls.Add(enginesGroupBox);
            Margin = new Padding(1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "Rocket_Designer";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "_";
            WindowState = FormWindowState.Maximized;
            Load += Rocket_Designer_Load;
            enginesGroupBox.ResumeLayout(false);
            enginesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEnginesNumericUpDown).EndInit();
            stagesGroupBox.ResumeLayout(false);
            stagesGroupBox.PerformLayout();
            fuelTankGroupbox.ResumeLayout(false);
            extraWideGroupBox.ResumeLayout(false);
            wideGroupBox.ResumeLayout(false);
            midGroupBox.ResumeLayout(false);
            thinGroupBox.ResumeLayout(false);
            extraThinGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fuelTankPic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fuelTankPic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)payloadPic).EndInit();
            payloadGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)enginePic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)launchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)enginePic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createStageButton;
        private GroupBox enginesGroupBox;
        private Button rd180Button;
        private GroupBox stagesGroupBox;
        private RadioButton stage2Button;
        private RadioButton stage1Button;
        private GroupBox fuelTankGroupbox;
        private PictureBox fuelTankPic1;
        private Button f1Button;
        private Button fuelTank0Button;
        private PictureBox fuelTankPic2;
        private GroupBox wideGroupBox;
        private GroupBox midGroupBox;
        private GroupBox thinGroupBox;
        private GroupBox extraThinGroupBox;
        private GroupBox extraWideGroupBox;
        private Button fuelTank1Button;
        private Button fuelTank2Button;
        private Button fuelTank4Button;
        private Button fuelTank3Button;
        private Button fuelTank13Button;
        private Button fuelTank14Button;
        private Button fuelTank12Button;
        private Button fuelTank10Button;
        private Button fuelTank11Button;
        private Button fuelTank9Button;
        private Button fuelTank7Button;
        private Button fuelTank8Button;
        private Button fuelTank6Button;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numEnginesNumericUpDown;
        private PictureBox payloadPic;
        private GroupBox payloadGroupBox;
        private Button removeStageButton;
        private Button launchButton;
        private PictureBox launchPictureBox;
        private PictureBox enginePic2;
        private PictureBox enginePic1;
        private System.Windows.Forms.Timer launchTimer;
        private Label budgetLabel;
        private Label rocketCostLabel;
        private Button mainMenuButton;
        private Button saveRocketButton;
        private Button fuelTank5Button;
        private ToolTip descriptionToolTip;
        private Button deleteRocketButton;
        private Label numEnginesLabel;
        private Button button2;
        private Button button3;
        private Button le7Button;
        private Button rs25Button;
        private Button raptorButton;
        private Button largePayloadButton;
        private Button smallPayloadButton;
        private Button extraLargePayloadButton;
        private Button mediumPayloadButton;
        private Button extraSmallPayloadButton;
    }
}