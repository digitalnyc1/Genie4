﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GenieClient
{
    [DesignerGenerated()]
    public partial class UCName : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCName));
            this._ListViewBase = new System.Windows.Forms.ListView();
            this._ContextMenuStripBase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._GroupBoxBase = new System.Windows.Forms.GroupBox();
            this._ButtonColorBg = new System.Windows.Forms.Button();
            this._LabelExampleColor = new System.Windows.Forms.Label();
            this._ButtonColorFg = new System.Windows.Forms.Button();
            this._LabelColor = new System.Windows.Forms.Label();
            this._TextBoxName = new System.Windows.Forms.TextBox();
            this._LabelAlias = new System.Windows.Forms.Label();
            this._ButtonApply = new System.Windows.Forms.Button();
            this._TextBoxColor = new System.Windows.Forms.TextBox();
            this._ColorDialogPicker = new System.Windows.Forms.ColorDialog();
            this._ToolStripMenu = new System.Windows.Forms.ToolStrip();
            this._ToolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this._ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._ToolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this._ToolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this._ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._ToolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this._ToolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this._ContextMenuStripBase.SuspendLayout();
            this._GroupBoxBase.SuspendLayout();
            this._ToolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ListViewBase
            // 
            this._ListViewBase.BackColor = System.Drawing.Color.Black;
            this._ListViewBase.ContextMenuStrip = this._ContextMenuStripBase;
            this._ListViewBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ListViewBase.ForeColor = System.Drawing.Color.White;
            this._ListViewBase.FullRowSelect = true;
            this._ListViewBase.Location = new System.Drawing.Point(0, 25);
            this._ListViewBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._ListViewBase.Name = "_ListViewBase";
            this._ListViewBase.ShowGroups = false;
            this._ListViewBase.Size = new System.Drawing.Size(814, 364);
            this._ListViewBase.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this._ListViewBase.TabIndex = 0;
            this._ListViewBase.UseCompatibleStateImageBehavior = false;
            this._ListViewBase.View = System.Windows.Forms.View.Details;
            this._ListViewBase.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewBase_SortColumnClick);
            this._ListViewBase.SelectedIndexChanged += new System.EventHandler(this.ListViewBase_SelectedIndexChanged);
            this._ListViewBase.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListViewBase_KeyUp);
            this._ListViewBase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListViewBase_MouseUp);
            // 
            // _ContextMenuStripBase
            // 
            this._ContextMenuStripBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._AddToolStripMenuItem,
            this._RemoveToolStripMenuItem});
            this._ContextMenuStripBase.Name = "ContextMenuStripBase";
            this._ContextMenuStripBase.Size = new System.Drawing.Size(118, 48);
            // 
            // _AddToolStripMenuItem
            // 
            this._AddToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_AddToolStripMenuItem.Image")));
            this._AddToolStripMenuItem.Name = "_AddToolStripMenuItem";
            this._AddToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this._AddToolStripMenuItem.Text = "Add";
            this._AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // _RemoveToolStripMenuItem
            // 
            this._RemoveToolStripMenuItem.Enabled = false;
            this._RemoveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_RemoveToolStripMenuItem.Image")));
            this._RemoveToolStripMenuItem.Name = "_RemoveToolStripMenuItem";
            this._RemoveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this._RemoveToolStripMenuItem.Text = "Remove";
            this._RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // _GroupBoxBase
            // 
            this._GroupBoxBase.AutoSize = true;
            this._GroupBoxBase.Controls.Add(this._ButtonColorBg);
            this._GroupBoxBase.Controls.Add(this._LabelExampleColor);
            this._GroupBoxBase.Controls.Add(this._ButtonColorFg);
            this._GroupBoxBase.Controls.Add(this._LabelColor);
            this._GroupBoxBase.Controls.Add(this._TextBoxName);
            this._GroupBoxBase.Controls.Add(this._LabelAlias);
            this._GroupBoxBase.Controls.Add(this._ButtonApply);
            this._GroupBoxBase.Controls.Add(this._TextBoxColor);
            this._GroupBoxBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._GroupBoxBase.Enabled = false;
            this._GroupBoxBase.Location = new System.Drawing.Point(0, 389);
            this._GroupBoxBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._GroupBoxBase.Name = "_GroupBoxBase";
            this._GroupBoxBase.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._GroupBoxBase.Size = new System.Drawing.Size(814, 126);
            this._GroupBoxBase.TabIndex = 2;
            this._GroupBoxBase.TabStop = false;
            // 
            // _ButtonColorBg
            // 
            this._ButtonColorBg.Image = ((System.Drawing.Image)(resources.GetObject("_ButtonColorBg.Image")));
            this._ButtonColorBg.Location = new System.Drawing.Point(491, 36);
            this._ButtonColorBg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._ButtonColorBg.Name = "_ButtonColorBg";
            this._ButtonColorBg.Size = new System.Drawing.Size(27, 27);
            this._ButtonColorBg.TabIndex = 12;
            this._ButtonColorBg.UseVisualStyleBackColor = true;
            this._ButtonColorBg.Click += new System.EventHandler(this.ButtonColorBg_Click);
            // 
            // _LabelExampleColor
            // 
            this._LabelExampleColor.BackColor = System.Drawing.Color.Black;
            this._LabelExampleColor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._LabelExampleColor.ForeColor = System.Drawing.Color.Black;
            this._LabelExampleColor.Location = new System.Drawing.Point(376, 37);
            this._LabelExampleColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._LabelExampleColor.Name = "_LabelExampleColor";
            this._LabelExampleColor.Size = new System.Drawing.Size(75, 23);
            this._LabelExampleColor.TabIndex = 11;
            this._LabelExampleColor.Text = "Color";
            this._LabelExampleColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _ButtonColorFg
            // 
            this._ButtonColorFg.Image = ((System.Drawing.Image)(resources.GetObject("_ButtonColorFg.Image")));
            this._ButtonColorFg.Location = new System.Drawing.Point(457, 36);
            this._ButtonColorFg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._ButtonColorFg.Name = "_ButtonColorFg";
            this._ButtonColorFg.Size = new System.Drawing.Size(27, 27);
            this._ButtonColorFg.TabIndex = 3;
            this._ButtonColorFg.UseVisualStyleBackColor = true;
            this._ButtonColorFg.Click += new System.EventHandler(this.ButtonColorFg_Click);
            // 
            // _LabelColor
            // 
            this._LabelColor.AutoSize = true;
            this._LabelColor.Location = new System.Drawing.Point(188, 18);
            this._LabelColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._LabelColor.Name = "_LabelColor";
            this._LabelColor.Size = new System.Drawing.Size(36, 15);
            this._LabelColor.TabIndex = 10;
            this._LabelColor.Text = "Color";
            // 
            // _TextBoxName
            // 
            this._TextBoxName.Location = new System.Drawing.Point(7, 37);
            this._TextBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._TextBoxName.Name = "_TextBoxName";
            this._TextBoxName.Size = new System.Drawing.Size(177, 23);
            this._TextBoxName.TabIndex = 0;
            this._TextBoxName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // _LabelAlias
            // 
            this._LabelAlias.AutoSize = true;
            this._LabelAlias.Location = new System.Drawing.Point(4, 18);
            this._LabelAlias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._LabelAlias.Name = "_LabelAlias";
            this._LabelAlias.Size = new System.Drawing.Size(39, 15);
            this._LabelAlias.TabIndex = 8;
            this._LabelAlias.Text = "Name";
            // 
            // _ButtonApply
            // 
            this._ButtonApply.Location = new System.Drawing.Point(7, 77);
            this._ButtonApply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._ButtonApply.Name = "_ButtonApply";
            this._ButtonApply.Size = new System.Drawing.Size(88, 27);
            this._ButtonApply.TabIndex = 2;
            this._ButtonApply.Text = "Apply";
            this._ButtonApply.UseVisualStyleBackColor = true;
            this._ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // _TextBoxColor
            // 
            this._TextBoxColor.Location = new System.Drawing.Point(191, 37);
            this._TextBoxColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._TextBoxColor.Name = "_TextBoxColor";
            this._TextBoxColor.Size = new System.Drawing.Size(177, 23);
            this._TextBoxColor.TabIndex = 1;
            this._TextBoxColor.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this._TextBoxColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxColor_KeyDown);
            this._TextBoxColor.Leave += new System.EventHandler(this.TextBoxColor_Leave);
            // 
            // _ColorDialogPicker
            // 
            this._ColorDialogPicker.FullOpen = true;
            // 
            // _ToolStripMenu
            // 
            this._ToolStripMenu.AllowMerge = false;
            this._ToolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._ToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ToolStripButtonRefresh,
            this._ToolStripSeparator2,
            this._ToolStripButtonAdd,
            this._ToolStripButtonRemove,
            this._ToolStripSeparator1,
            this._ToolStripButtonLoad,
            this._ToolStripButtonSave});
            this._ToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this._ToolStripMenu.Name = "_ToolStripMenu";
            this._ToolStripMenu.Size = new System.Drawing.Size(814, 25);
            this._ToolStripMenu.TabIndex = 6;
            // 
            // _ToolStripButtonRefresh
            // 
            this._ToolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("_ToolStripButtonRefresh.Image")));
            this._ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ToolStripButtonRefresh.Name = "_ToolStripButtonRefresh";
            this._ToolStripButtonRefresh.Size = new System.Drawing.Size(66, 22);
            this._ToolStripButtonRefresh.Text = "Refresh";
            // 
            // _ToolStripSeparator2
            // 
            this._ToolStripSeparator2.Name = "_ToolStripSeparator2";
            this._ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _ToolStripButtonAdd
            // 
            this._ToolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("_ToolStripButtonAdd.Image")));
            this._ToolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ToolStripButtonAdd.Name = "_ToolStripButtonAdd";
            this._ToolStripButtonAdd.Size = new System.Drawing.Size(49, 22);
            this._ToolStripButtonAdd.Text = "Add";
            this._ToolStripButtonAdd.Click += new System.EventHandler(this.ToolStripButtonAdd_Click);
            // 
            // _ToolStripButtonRemove
            // 
            this._ToolStripButtonRemove.Enabled = false;
            this._ToolStripButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("_ToolStripButtonRemove.Image")));
            this._ToolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ToolStripButtonRemove.Name = "_ToolStripButtonRemove";
            this._ToolStripButtonRemove.Size = new System.Drawing.Size(70, 22);
            this._ToolStripButtonRemove.Text = "Remove";
            this._ToolStripButtonRemove.Click += new System.EventHandler(this.ToolStripButtonRemove_Click);
            // 
            // _ToolStripSeparator1
            // 
            this._ToolStripSeparator1.Name = "_ToolStripSeparator1";
            this._ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _ToolStripButtonLoad
            // 
            this._ToolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("_ToolStripButtonLoad.Image")));
            this._ToolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ToolStripButtonLoad.Name = "_ToolStripButtonLoad";
            this._ToolStripButtonLoad.Size = new System.Drawing.Size(53, 22);
            this._ToolStripButtonLoad.Text = "Load";
            this._ToolStripButtonLoad.Click += new System.EventHandler(this.ToolStripButtonLoad_Click);
            // 
            // _ToolStripButtonSave
            // 
            this._ToolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("_ToolStripButtonSave.Image")));
            this._ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ToolStripButtonSave.Name = "_ToolStripButtonSave";
            this._ToolStripButtonSave.Size = new System.Drawing.Size(51, 22);
            this._ToolStripButtonSave.Text = "Save";
            this._ToolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // UCName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._ListViewBase);
            this.Controls.Add(this._GroupBoxBase);
            this.Controls.Add(this._ToolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UCName";
            this.Size = new System.Drawing.Size(814, 515);
            this.Load += new System.EventHandler(this.UCWindows_Load);
            this._ContextMenuStripBase.ResumeLayout(false);
            this._GroupBoxBase.ResumeLayout(false);
            this._GroupBoxBase.PerformLayout();
            this._ToolStripMenu.ResumeLayout(false);
            this._ToolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ListView _ListViewBase;

        internal ListView ListViewBase
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewBase;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewBase != null)
                {
                    _ListViewBase.KeyUp -= ListViewBase_KeyUp;
                    _ListViewBase.MouseUp -= ListViewBase_MouseUp;
                    _ListViewBase.SelectedIndexChanged -= ListViewBase_SelectedIndexChanged;
                }

                _ListViewBase = value;
                if (_ListViewBase != null)
                {
                    _ListViewBase.KeyUp += ListViewBase_KeyUp;
                    _ListViewBase.MouseUp += ListViewBase_MouseUp;
                    _ListViewBase.SelectedIndexChanged += ListViewBase_SelectedIndexChanged;
                }
            }
        }

        private GroupBox _GroupBoxBase;

        internal GroupBox GroupBoxBase
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBoxBase;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBoxBase != null)
                {
                }

                _GroupBoxBase = value;
                if (_GroupBoxBase != null)
                {
                }
            }
        }

        private Label _LabelColor;

        internal Label LabelColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelColor != null)
                {
                }

                _LabelColor = value;
                if (_LabelColor != null)
                {
                }
            }
        }

        private TextBox _TextBoxName;

        internal TextBox TextBoxName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxName != null)
                {
                    _TextBoxName.TextChanged -= TextBox_TextChanged;
                }

                _TextBoxName = value;
                if (_TextBoxName != null)
                {
                    _TextBoxName.TextChanged += TextBox_TextChanged;
                }
            }
        }

        private Label _LabelAlias;

        internal Label LabelAlias
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelAlias;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelAlias != null)
                {
                }

                _LabelAlias = value;
                if (_LabelAlias != null)
                {
                }
            }
        }

        private Button _ButtonApply;

        internal Button ButtonApply
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonApply;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonApply != null)
                {
                    _ButtonApply.Click -= ButtonApply_Click;
                }

                _ButtonApply = value;
                if (_ButtonApply != null)
                {
                    _ButtonApply.Click += ButtonApply_Click;
                }
            }
        }

        private TextBox _TextBoxColor;

        internal TextBox TextBoxColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxColor != null)
                {
                    _TextBoxColor.KeyDown -= TextBoxColor_KeyDown;
                    _TextBoxColor.Leave -= TextBoxColor_Leave;
                    _TextBoxColor.TextChanged -= TextBox_TextChanged;
                }

                _TextBoxColor = value;
                if (_TextBoxColor != null)
                {
                    _TextBoxColor.KeyDown += TextBoxColor_KeyDown;
                    _TextBoxColor.Leave += TextBoxColor_Leave;
                    _TextBoxColor.TextChanged += TextBox_TextChanged;
                }
            }
        }

        private ColorDialog _ColorDialogPicker;

        internal ColorDialog ColorDialogPicker
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColorDialogPicker;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColorDialogPicker != null)
                {
                }

                _ColorDialogPicker = value;
                if (_ColorDialogPicker != null)
                {
                }
            }
        }

        private Button _ButtonColorFg;

        internal Button ButtonColorFg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonColorFg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonColorFg != null)
                {
                    _ButtonColorFg.Click -= ButtonColorFg_Click;
                }

                _ButtonColorFg = value;
                if (_ButtonColorFg != null)
                {
                    _ButtonColorFg.Click += ButtonColorFg_Click;
                }
            }
        }

        private Label _LabelExampleColor;

        internal Label LabelExampleColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelExampleColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelExampleColor != null)
                {
                }

                _LabelExampleColor = value;
                if (_LabelExampleColor != null)
                {
                }
            }
        }

        private Button _ButtonColorBg;

        internal Button ButtonColorBg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonColorBg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonColorBg != null)
                {
                    _ButtonColorBg.Click -= ButtonColorBg_Click;
                }

                _ButtonColorBg = value;
                if (_ButtonColorBg != null)
                {
                    _ButtonColorBg.Click += ButtonColorBg_Click;
                }
            }
        }

        private ToolStrip _ToolStripMenu;

        internal ToolStrip ToolStripMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripMenu != null)
                {
                }

                _ToolStripMenu = value;
                if (_ToolStripMenu != null)
                {
                }
            }
        }

        private ToolStripButton _ToolStripButtonRefresh;

        internal ToolStripButton ToolStripButtonRefresh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonRefresh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonRefresh != null)
                {
                }

                _ToolStripButtonRefresh = value;
                if (_ToolStripButtonRefresh != null)
                {
                }
            }
        }

        private ToolStripSeparator _ToolStripSeparator2;

        internal ToolStripSeparator ToolStripSeparator2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripSeparator2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripSeparator2 != null)
                {
                }

                _ToolStripSeparator2 = value;
                if (_ToolStripSeparator2 != null)
                {
                }
            }
        }

        private ToolStripButton _ToolStripButtonAdd;

        internal ToolStripButton ToolStripButtonAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonAdd != null)
                {
                    _ToolStripButtonAdd.Click -= ToolStripButtonAdd_Click;
                }

                _ToolStripButtonAdd = value;
                if (_ToolStripButtonAdd != null)
                {
                    _ToolStripButtonAdd.Click += ToolStripButtonAdd_Click;
                }
            }
        }

        private ToolStripButton _ToolStripButtonRemove;

        internal ToolStripButton ToolStripButtonRemove
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonRemove;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonRemove != null)
                {
                    _ToolStripButtonRemove.Click -= ToolStripButtonRemove_Click;
                }

                _ToolStripButtonRemove = value;
                if (_ToolStripButtonRemove != null)
                {
                    _ToolStripButtonRemove.Click += ToolStripButtonRemove_Click;
                }
            }
        }

        private ToolStripSeparator _ToolStripSeparator1;

        internal ToolStripSeparator ToolStripSeparator1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripSeparator1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripSeparator1 != null)
                {
                }

                _ToolStripSeparator1 = value;
                if (_ToolStripSeparator1 != null)
                {
                }
            }
        }

        private ToolStripButton _ToolStripButtonLoad;

        internal ToolStripButton ToolStripButtonLoad
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonLoad;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonLoad != null)
                {
                    _ToolStripButtonLoad.Click -= ToolStripButtonLoad_Click;
                }

                _ToolStripButtonLoad = value;
                if (_ToolStripButtonLoad != null)
                {
                    _ToolStripButtonLoad.Click += ToolStripButtonLoad_Click;
                }
            }
        }

        private ToolStripButton _ToolStripButtonSave;

        internal ToolStripButton ToolStripButtonSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonSave != null)
                {
                    _ToolStripButtonSave.Click -= ToolStripButtonSave_Click;
                }

                _ToolStripButtonSave = value;
                if (_ToolStripButtonSave != null)
                {
                    _ToolStripButtonSave.Click += ToolStripButtonSave_Click;
                }
            }
        }

        private ContextMenuStrip _ContextMenuStripBase;

        internal ContextMenuStrip ContextMenuStripBase
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContextMenuStripBase;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContextMenuStripBase != null)
                {
                }

                _ContextMenuStripBase = value;
                if (_ContextMenuStripBase != null)
                {
                }
            }
        }

        private ToolStripMenuItem _AddToolStripMenuItem;

        internal ToolStripMenuItem AddToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AddToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AddToolStripMenuItem != null)
                {
                    _AddToolStripMenuItem.Click -= AddToolStripMenuItem_Click;
                }

                _AddToolStripMenuItem = value;
                if (_AddToolStripMenuItem != null)
                {
                    _AddToolStripMenuItem.Click += AddToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _RemoveToolStripMenuItem;

        internal ToolStripMenuItem RemoveToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RemoveToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RemoveToolStripMenuItem != null)
                {
                    _RemoveToolStripMenuItem.Click -= RemoveToolStripMenuItem_Click;
                }

                _RemoveToolStripMenuItem = value;
                if (_RemoveToolStripMenuItem != null)
                {
                    _RemoveToolStripMenuItem.Click += RemoveToolStripMenuItem_Click;
                }
            }
        }
    }
}