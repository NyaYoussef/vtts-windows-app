using App.Gwin.Components.Manager.EntryForms.PLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Gwin;
using vtts.Entities.MissionManagement;
using App.Gwin.Fields;
using App.Gwin.Entities;
using vtts.Entities.StaffManagement;

namespace vtts.Presentation.MissionManagement
{
    public class MissionOrderPLO : IGwinPLO
    {
        public void FormAfterInit(BaseEntryForm EntryForm)
        {

          EntryForm.Fields[nameof(MissionOrder.Staff)].Hide();
        }

        public void FormBeforInit(BaseEntryForm EntryForm)
        {
            
        }

        public void ValidatingFiled(BaseEntryForm EntryForm , object sender)
        {
            
        }

        public void ValueChanged(BaseEntryForm EntryForm, object sender)
        {
            BaseField field = sender as BaseField;

            switch (field.Name)
            {
                case nameof(MissionOrder.MissionConvocation):
                    {
                        ManyToOneField missionField = field as ManyToOneField;
                        MissionConvocation MissionConvocation = missionField.SelectedItem as MissionConvocation;

                        if (MissionConvocation != null)
                        {
                            
                            EntryForm.Fields[nameof(MissionOrder.Staff)].Show();
                            ManyToOneField StaffField = EntryForm.Fields[nameof(MissionOrder.Staff)] as ManyToOneField;

                            List<Staff> ls = MissionConvocation.Staffs;
                           //  ls.Insert(0, new Staff()); throw Datetime2 exception
                            StaffField.DataSource = ls;
                        }


                    }
                    break;

            }

          

        }
    }
}
