using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ShoppingListTEST
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LoadButton(object sender, EventArgs e)
        {  
                LeftList.Items.Add("Beans");
                LeftList.Items.Add("Sugar");
                LeftList.Items.Add("Honey");
                LeftList.Items.Add("Bread");
                LeftList.Items.Add("Milk");
        }

        public void AddItem(object sender, EventArgs e)
        {
            bool isDuplicate = false;
            foreach (ListItem item in LeftList.Items)
            {
                if (item.ToString().Equals(txtboxitem.Text))
                {
                    isDuplicate = true;
                } 
            }
            if (isDuplicate)
            {
                MessageBox.Show("item already exists");
            }
             else
            {
                string NewItem = txtboxitem.Text;
                LeftList.Items.Insert(LeftList.Items.Count, NewItem);
            }
        }
        public void ClearListButton(object sender, EventArgs e)
        {
            LeftList.Items.Clear();
        }
        public void DeleteItem(object sender, EventArgs e)
        {
            List<ListItem> itemtodelete = new List<ListItem>();
            foreach (ListItem item in LeftList.Items)
            {
                if (item.Selected)
                {
                    itemtodelete.Add(item);
                }
            }
            foreach (ListItem item in itemtodelete)
            {
                LeftList.Items.Remove(item);
            }
        }
        public void RenameItem(object sender, EventArgs e)
        {
            string RenameText = txtboxitem.Text;
            int SelectedItemIndex = LeftList.SelectedIndex;
            LeftList.Items.Remove(LeftList.SelectedValue);
            LeftList.Items.Insert(SelectedItemIndex, RenameText);
        }


        public void PrioritiseItem(object sender, EventArgs e)
        {   //adds a (!) to mark as priority item
            int selectedItemIndex = LeftList.SelectedIndex;
            string prioritiseitem = LeftList.SelectedValue + " (!)";
            LeftList.Items.Insert(0, prioritiseitem);
            LeftList.Items.Remove(LeftList.SelectedValue);
        }

       public void MoveToRight(object sender, EventArgs e) 
        {   List<ListItem> MoveList = new List<ListItem>();
            foreach(ListItem item in LeftList.Items)

            {
                if (item.Selected)
                {
                    RightList.Items.Add(item);
                    MoveList.Add(item);

                }
            }

            foreach(ListItem item in MoveList)
            {
                LeftList.Items.Remove(item);
            }
        }

        public void MoveToLeft(object sender, EventArgs e)
        {
            List<ListItem> MoveList = new List<ListItem>();
            foreach (ListItem item in RightList.Items)
            {
                if (item.Selected)
                {
                    LeftList.Items.Add(item);
                    MoveList.Add(item);

                }
            }

            foreach (ListItem item in MoveList)
            {
                RightList.Items.Remove(item);
            }
        }

        public void MoveUp(object sender, EventArgs e)
        {
            List<ListItem> repositionlist = new List<ListItem>();
            int selectedItemIndex = LeftList.SelectedIndex;
            int repositionindex = LeftList.SelectedIndex - 1;
            bool ispriority = false;
            foreach (ListItem item in LeftList.Items)
            {
               if (item.Selected)
                {
                    repositionlist.Add(item);
                }
            }
            foreach (ListItem item in repositionlist)
            {
                if(repositionindex != -1)
                {
                    if (LeftList.Items[repositionindex].Text.Contains("(!)")) //checks for (!) to see if its priority item
                    {
                        MessageBox.Show("Cant move above priority item");
                        ispriority = true;
                    }
                }
                
                if (ispriority == false)
                {
                    LeftList.Items.Remove(item);
                }
                
                if (selectedItemIndex != 0)
                {
                
                    if (ispriority == false)
                    {
                        LeftList.Items.Insert(repositionindex, item);
                        repositionindex++;
                    }
                }
                if (selectedItemIndex == 0)
                {
                
                    if (ispriority == false)
                    {
                        LeftList.Items.Insert(LeftList.Items.Count, item);
                        repositionindex++;
                    }
                }
                if(ispriority == true)
                {
                    ispriority = false;
                }

            }
        }

        public void MoveDown(object sender, EventArgs e)
        {
           int z = LeftList.Items.Count;
            Boolean isLastItem = false;
            List<ListItem> repositionlist = new List<ListItem>();
            int selectedItemIndex = LeftList.SelectedIndex;
            int repositionindex = LeftList.SelectedIndex + 1;
            foreach (ListItem item in LeftList.Items)
            {
                if (item.Text.Contains("(!)"))
                {
                    MessageBox.Show("Cannot move down priority item");
                }
                else
                {
                    if (item.Selected)
                    {
                        if (LeftList.Items.IndexOf(item) == LeftList.Items.Count - 1)
                        {
                            isLastItem = true;
                        }

                        repositionlist.Add(item);
                    }
                }
                 
            }
            foreach (ListItem item in repositionlist)
            {
                LeftList.Items.Remove(item);

            }


            repositionindex = isLastItem ? 0 : repositionindex;
            foreach (ListItem item in repositionlist)
            {

                ////int firstindex = 0; //not needed

                LeftList.Items.Insert(repositionindex, item);
                repositionindex++;




            }
        }

    }
}