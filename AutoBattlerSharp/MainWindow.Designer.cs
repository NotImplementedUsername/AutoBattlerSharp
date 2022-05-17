﻿namespace AutoBattlerSharp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.DebugToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddNewEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanelPadded = new System.Windows.Forms.Panel();
            this.HorizontalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FightersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.AlliesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EnemiesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BottomSplitContainerVertical = new System.Windows.Forms.SplitContainer();
            this.AutoplayButton = new System.Windows.Forms.Button();
            this.FightButton = new System.Windows.Forms.Button();
            this.FightLogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.TopToolStrip.SuspendLayout();
            this.MainPanelPadded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).BeginInit();
            this.HorizontalSplitContainer.Panel1.SuspendLayout();
            this.HorizontalSplitContainer.Panel2.SuspendLayout();
            this.HorizontalSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FightersSplitContainer)).BeginInit();
            this.FightersSplitContainer.Panel1.SuspendLayout();
            this.FightersSplitContainer.Panel2.SuspendLayout();
            this.FightersSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainerVertical)).BeginInit();
            this.BottomSplitContainerVertical.Panel1.SuspendLayout();
            this.BottomSplitContainerVertical.Panel2.SuspendLayout();
            this.BottomSplitContainerVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebugToolStripDropDownButton});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(800, 25);
            this.TopToolStrip.TabIndex = 0;
            this.TopToolStrip.Text = "TopToolStrip";
            // 
            // DebugToolStripDropDownButton
            // 
            this.DebugToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DebugToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewEntityToolStripMenuItem});
            this.DebugToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("DebugToolStripDropDownButton.Image")));
            this.DebugToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DebugToolStripDropDownButton.Name = "DebugToolStripDropDownButton";
            this.DebugToolStripDropDownButton.Size = new System.Drawing.Size(55, 22);
            this.DebugToolStripDropDownButton.Text = "Debug";
            // 
            // AddNewEntityToolStripMenuItem
            // 
            this.AddNewEntityToolStripMenuItem.Name = "AddNewEntityToolStripMenuItem";
            this.AddNewEntityToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddNewEntityToolStripMenuItem.Text = "Add new entity";
            this.AddNewEntityToolStripMenuItem.Click += new System.EventHandler(this.AddNewEntityToolStripMenuItem_Click);
            // 
            // MainPanelPadded
            // 
            this.MainPanelPadded.Controls.Add(this.HorizontalSplitContainer);
            this.MainPanelPadded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelPadded.Location = new System.Drawing.Point(0, 25);
            this.MainPanelPadded.Name = "MainPanelPadded";
            this.MainPanelPadded.Padding = new System.Windows.Forms.Padding(5);
            this.MainPanelPadded.Size = new System.Drawing.Size(800, 425);
            this.MainPanelPadded.TabIndex = 1;
            // 
            // HorizontalSplitContainer
            // 
            this.HorizontalSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HorizontalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizontalSplitContainer.Location = new System.Drawing.Point(5, 5);
            this.HorizontalSplitContainer.Name = "HorizontalSplitContainer";
            this.HorizontalSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorizontalSplitContainer.Panel1
            // 
            this.HorizontalSplitContainer.Panel1.Controls.Add(this.FightersSplitContainer);
            // 
            // HorizontalSplitContainer.Panel2
            // 
            this.HorizontalSplitContainer.Panel2.AutoScroll = true;
            this.HorizontalSplitContainer.Panel2.Controls.Add(this.BottomSplitContainerVertical);
            this.HorizontalSplitContainer.Size = new System.Drawing.Size(790, 415);
            this.HorizontalSplitContainer.SplitterDistance = 207;
            this.HorizontalSplitContainer.TabIndex = 0;
            // 
            // FightersSplitContainer
            // 
            this.FightersSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FightersSplitContainer.IsSplitterFixed = true;
            this.FightersSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.FightersSplitContainer.Name = "FightersSplitContainer";
            // 
            // FightersSplitContainer.Panel1
            // 
            this.FightersSplitContainer.Panel1.Controls.Add(this.AlliesFlowLayoutPanel);
            // 
            // FightersSplitContainer.Panel2
            // 
            this.FightersSplitContainer.Panel2.Controls.Add(this.EnemiesFlowLayoutPanel);
            this.FightersSplitContainer.Size = new System.Drawing.Size(788, 205);
            this.FightersSplitContainer.SplitterDistance = 394;
            this.FightersSplitContainer.TabIndex = 0;
            // 
            // AlliesFlowLayoutPanel
            // 
            this.AlliesFlowLayoutPanel.AutoScroll = true;
            this.AlliesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlliesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlliesFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AlliesFlowLayoutPanel.Name = "AlliesFlowLayoutPanel";
            this.AlliesFlowLayoutPanel.Size = new System.Drawing.Size(394, 205);
            this.AlliesFlowLayoutPanel.TabIndex = 0;
            // 
            // EnemiesFlowLayoutPanel
            // 
            this.EnemiesFlowLayoutPanel.AutoScroll = true;
            this.EnemiesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemiesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemiesFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.EnemiesFlowLayoutPanel.Name = "EnemiesFlowLayoutPanel";
            this.EnemiesFlowLayoutPanel.Size = new System.Drawing.Size(390, 205);
            this.EnemiesFlowLayoutPanel.TabIndex = 0;
            // 
            // BottomSplitContainerVertical
            // 
            this.BottomSplitContainerVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomSplitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomSplitContainerVertical.IsSplitterFixed = true;
            this.BottomSplitContainerVertical.Location = new System.Drawing.Point(0, 0);
            this.BottomSplitContainerVertical.Name = "BottomSplitContainerVertical";
            // 
            // BottomSplitContainerVertical.Panel1
            // 
            this.BottomSplitContainerVertical.Panel1.Controls.Add(this.AutoplayButton);
            this.BottomSplitContainerVertical.Panel1.Controls.Add(this.FightButton);
            // 
            // BottomSplitContainerVertical.Panel2
            // 
            this.BottomSplitContainerVertical.Panel2.Controls.Add(this.FightLogRichTextBox);
            this.BottomSplitContainerVertical.Size = new System.Drawing.Size(790, 204);
            this.BottomSplitContainerVertical.SplitterDistance = 103;
            this.BottomSplitContainerVertical.TabIndex = 0;
            // 
            // AutoplayButton
            // 
            this.AutoplayButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AutoplayButton.Location = new System.Drawing.Point(0, 156);
            this.AutoplayButton.Name = "AutoplayButton";
            this.AutoplayButton.Size = new System.Drawing.Size(101, 23);
            this.AutoplayButton.TabIndex = 2;
            this.AutoplayButton.Text = "Autoplay";
            this.AutoplayButton.UseVisualStyleBackColor = true;
            this.AutoplayButton.Click += new System.EventHandler(this.AutoplayButton_Click);
            // 
            // FightButton
            // 
            this.FightButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FightButton.Location = new System.Drawing.Point(0, 179);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(101, 23);
            this.FightButton.TabIndex = 0;
            this.FightButton.Text = "Fight";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // FightLogRichTextBox
            // 
            this.FightLogRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FightLogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FightLogRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.FightLogRichTextBox.Name = "FightLogRichTextBox";
            this.FightLogRichTextBox.ReadOnly = true;
            this.FightLogRichTextBox.Size = new System.Drawing.Size(681, 202);
            this.FightLogRichTextBox.TabIndex = 1;
            this.FightLogRichTextBox.Text = "";
            this.FightLogRichTextBox.WordWrap = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanelPadded);
            this.Controls.Add(this.TopToolStrip);
            this.Name = "MainWindow";
            this.Text = "AutoBattlerSharp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.MainPanelPadded.ResumeLayout(false);
            this.HorizontalSplitContainer.Panel1.ResumeLayout(false);
            this.HorizontalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).EndInit();
            this.HorizontalSplitContainer.ResumeLayout(false);
            this.FightersSplitContainer.Panel1.ResumeLayout(false);
            this.FightersSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FightersSplitContainer)).EndInit();
            this.FightersSplitContainer.ResumeLayout(false);
            this.BottomSplitContainerVertical.Panel1.ResumeLayout(false);
            this.BottomSplitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainerVertical)).EndInit();
            this.BottomSplitContainerVertical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip TopToolStrip;
        private Panel MainPanelPadded;
        private SplitContainer HorizontalSplitContainer;
        private ToolStripDropDownButton DebugToolStripDropDownButton;
        private ToolStripMenuItem AddNewEntityToolStripMenuItem;
        private Button FightButton;
        private RichTextBox FightLogRichTextBox;
        private SplitContainer BottomSplitContainerVertical;
        private SplitContainer FightersSplitContainer;
        private FlowLayoutPanel AlliesFlowLayoutPanel;
        private FlowLayoutPanel EnemiesFlowLayoutPanel;
        private Button AutoplayButton;
        private System.Windows.Forms.Timer GameTimer;
    }
}