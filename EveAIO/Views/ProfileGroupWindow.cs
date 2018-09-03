﻿namespace EveAIO.Views
{
    using EveAIO;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class ProfileGroupWindow : Window, IComponentConnector
    {
        internal Button BtnClose;
        internal Border border;
        public DataGrid gvGroups;
        internal Button btnSave;
        internal Button btnCancel;
        private bool _contentLoaded;

        public ProfileGroupWindow(Window owner)
        {
            Class7.RIuqtBYzWxthF();
            this.InitializeComponent();
            base.Owner = owner;
            ICollectionView defaultView = CollectionViewSource.GetDefaultView(Global.SETTINGS.PROFILES_GROUPS);
            this.gvGroups.ItemsSource = defaultView;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            base.Close();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            base.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            base.Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.DragMove();
        }

        private void gvGroups_AutoGeneratedColumns(object sender, EventArgs e)
        {
            foreach (DataGridColumn column in this.gvGroups.Columns)
            {
                if (column.Header.ToString() == "Name")
                {
                    DataGridTextColumn column3 = column as DataGridTextColumn;
                    if (column3 != null)
                    {
                        column3.Header = "NAME";
                        column3.Width = new DataGridLength(1.0, DataGridLengthUnitType.Star);
                        column3.CanUserResize = false;
                        column3.HeaderStyle = this.gvGroups.FindResource("columnHeader") as Style;
                        column3.ElementStyle = this.gvGroups.FindResource("txtStyle") as Style;
                        column3.EditingElementStyle = Application.Current.MainWindow.FindResource("TextBoxGrid") as Style;
                    }
                }
                else
                {
                    DataGridTextColumn column2 = column as DataGridTextColumn;
                    if (column2 != null)
                    {
                        column2.Header = "PROFILES";
                        column2.Width = 70.0;
                        column2.MinWidth = 70.0;
                        column2.CanUserResize = false;
                        column2.HeaderStyle = this.gvGroups.FindResource("columnHeader") as Style;
                        column2.ElementStyle = this.gvGroups.FindResource("txtStyle") as Style;
                        column2.EditingElementStyle = Global.SETTINGS.EnvLight ? (this.gvGroups.FindResource("textStyleLight") as Style) : (this.gvGroups.FindResource("textStyleDark") as Style);
                    }
                }
            }
        }

        private void gvGroups_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "Id")
            {
                e.Cancel = true;
            }
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/EveAIO;component/views/profilegroupwindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    ((Grid) target).MouseLeftButtonDown += new MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
                    return;

                case 2:
                    this.BtnClose = (Button) target;
                    this.BtnClose.Click += new RoutedEventHandler(this.BtnClose_Click);
                    return;

                case 3:
                    this.border = (Border) target;
                    return;

                case 4:
                    this.gvGroups = (DataGrid) target;
                    this.gvGroups.AutoGeneratingColumn += new EventHandler<DataGridAutoGeneratingColumnEventArgs>(this.gvGroups_AutoGeneratingColumn);
                    this.gvGroups.AutoGeneratedColumns += new EventHandler(this.gvGroups_AutoGeneratedColumns);
                    return;

                case 5:
                    this.btnSave = (Button) target;
                    this.btnSave.Click += new RoutedEventHandler(this.btnSave_Click);
                    return;

                case 6:
                    this.btnCancel = (Button) target;
                    this.btnCancel.Click += new RoutedEventHandler(this.btnCancel_Click);
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

