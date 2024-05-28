using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ElDee
{


    class MyList : Panel
    {
        //
        public delegate void MyDel();
        public event MyDel SelEvent;
        //
        public delegate void Mydel2();
        public event Mydel2 CountChanged;
        

        List<ListItem> _items;
        ListItem _selectedItem;
        int _count;
        public ListItem SelectedItem => _selectedItem;
        public List<ListItem> Items => _items;
        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                CountChanged();

            }
        } 

        
        public MyList()
        {
            CountChanged = () => {};
            _items = new List<ListItem>();
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            Count = 0;
            base.OnControlRemoved(e);
        }

        public void AddItem(string id, string s1, string s2 = null, string s3 = null, string s4 = null)
        {
            var newItem = s3 == null ? new ListItem(id, s1, s2, this) : new ListItem(id, s1, s2, s3, s4, this);
            _items.Add(newItem);
            Controls.Add(newItem);
            Count++;
        }

        

        public void MouseClick2(object sender, MouseEventArgs e)
        {
            foreach (Control item in Controls)
                if (sender is ListItem)
                    if (((ListItem)sender).Equals(item))
                    {
                        _selectedItem = item as ListItem;
                        SelEvent();
                        break;
                    }
            
        }

    }

    sealed class ListItem : Panel
    {
        private readonly Label _l1;
        public string Text1 => _l1.Text;
        private readonly Label _l2;
        public string Text2 => _l2.Text;
        private readonly Label _l3;
        public string Text3 => _l3.Text;
        private readonly Label _l4;
        public string Text4 => _l4.Text;

        private string _id;
        public string Id => _id;

        private readonly MyList _listok;

        private readonly bool _isStudent;
        public bool IsStudent => _isStudent;

        public ListItem(string id, string s1, string s2, string s3, string s4, MyList mylist)
        {
            MouseClick += MouseClick1;
            BorderStyle = BorderStyle.FixedSingle;
            Dock = DockStyle.Top;
            Height = 68;
            BackColor = Color.White;
            _listok = mylist;

            _l1 = new Label
            {
                Location = new Point(0, 0),
                Size = new Size(200, 24),
                Text = s1,
                Font = new Font("Times New Roman", 15)
            };
            _l1.MouseClick += MouseClick1;
            Controls.Add(_l1);


            _l2 = new Label
            {
                Location = new Point(0, 20),
                Size = new Size(200, 24),
                Text = s2,
                Font = new Font("Times New Roman", 15)
            };
            _l2.MouseClick += MouseClick1;
            Controls.Add(_l2);

            _l3 = new Label
            {
                Location = new Point(0, 40),
                Size = new Size(200, 24),
                Text = s3,
                Font = new Font("Times New Roman", 15)
            };
            _l3.MouseClick += MouseClick1;
            Controls.Add(_l3);

            _l4 = new Label
            {
                Location = new Point(300, 20),
                Size = new Size(200, 24),
                Text = s4,
                Font = new Font("Segoe UI", 14),
                TextAlign = ContentAlignment.MiddleRight
            };
            _l4.MouseClick += MouseClick1;
            Controls.Add(_l4);
            _isStudent = true;

            _id = id;
        }


        public ListItem(string id, string mainStr, string secondStr, MyList mylist)
        {
            MouseClick += MouseClick1;
            BorderStyle = BorderStyle.FixedSingle;
            Dock = DockStyle.Top;
            Height = 68;
            BackColor = Color.White;
            _listok = mylist;

            _l1 = new Label
            {
                Location = new Point(15, 20),
                Text = mainStr,
                Size = new Size(280, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 15)
            };
            _l1.MouseClick += MouseClick1;
            Controls.Add(_l1);

            _l2 = new Label
            {
                Location = new Point(280, 20),
                TextAlign = ContentAlignment.MiddleRight,
                Text = "Студентов в группе: " + secondStr,
                Size = new Size(220, 30),
                Font = new Font("Times New Roman", 15)
            };
            _l2.MouseClick += MouseClick1;
            Controls.Add(_l2);
            _isStudent = false;

            _id = id;
        }

        

        private void MouseClick1(object sender, MouseEventArgs e)
        {
            foreach (var item in _listok.Items)
                item.BackColor = Color.White;
            if (sender is Panel)
            {
                (sender as Panel).BackColor = Color.FromArgb(140, 160, 250);
                _listok.MouseClick2(this, e);
            }
            else
            {
                foreach (Control item in Controls)
                    BackColor = Color.FromArgb(140, 160, 250);
                _listok.MouseClick2(this, e);
            }

        }
    }
}
