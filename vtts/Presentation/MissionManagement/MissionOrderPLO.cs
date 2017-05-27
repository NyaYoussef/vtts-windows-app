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
using vtts.Entities.MissionManagement.Enumeration;
using App;

namespace vtts.Presentation.MissionManagement
{
    public class MissionOrderPLO : IGwinPLO
    {
        Staff staffG = null;
        MeansTransportCategories meanscatG = MeansTransportCategories.Public;
        public void FormAfterInit(BaseEntryForm EntryForm)
        {

          EntryForm.Fields[nameof(MissionOrder.Staff)].Hide();
            EntryForm.Fields[nameof(MissionOrder.Car)].Hide();
            EntryForm.Fields[nameof(MissionOrder.ValidationDate)].Hide();
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
                case  nameof(MissionOrder.MissionConvocation):
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
                  case  nameof(MissionOrder.MeansTransportCategory):
                    {
                       
                        ComboBoxField missioncarfieled = field as ComboBoxField;
                       
                         meanscatG =(MeansTransportCategories) missioncarfieled.Value;
                      
                        this.ShowCars(meanscatG,staffG, EntryForm);
                    }
                        break;
                case nameof(MissionOrder.Validation):
                    {
                        BooleanField missionValiditionfield = field as BooleanField;
                        bool validation = (bool)missionValiditionfield.Value;
                        if(validation)
                        {
                            EntryForm.Fields[nameof(MissionOrder.ValidationDate)].Show();
                            BooleanField validitionfield = EntryForm.Fields[nameof(MissionOrder.ValidationDate)] as BooleanField;

                        }
                        else
                        {
                            EntryForm.Fields[nameof(MissionOrder.ValidationDate)].Hide();
                            BooleanField validitionfield = EntryForm.Fields[nameof(MissionOrder.ValidationDate)] as BooleanField;

                        }

                    }
                    break;
                case nameof(MissionOrder.Staff):
                    {
                        ManyToOneField missionStaffield = field as ManyToOneField;
                       
                        staffG = missionStaffield.SelectedItem as Staff;
                       
                        this.ShowCars(meanscatG,staffG, EntryForm);

                    }
                    break;

            }
        }
        public void ShowCars(MeansTransportCategories meansTransportCategories,Staff staff,BaseEntryForm EntryForm)
        {
           
            if (staff == null || meansTransportCategories == MeansTransportCategories.Public)
            {
                EntryForm.Fields[nameof(MissionOrder.Car)].Hide();

            }
            else
            if (staff != null && meansTransportCategories == MeansTransportCategories.Public)
            {
                EntryForm.Fields[nameof(MissionOrder.Car)].Hide();

            }
            else
            if (staff == null && meansTransportCategories == MeansTransportCategories.Voiture_de_Service)
            {

                EntryForm.Fields[nameof(MissionOrder.Car)].Show();
                ManyToOneField CarField = EntryForm.Fields[nameof(MissionOrder.Car)] as ManyToOneField;
                List<Car> ls = new ModelContext().Cars.Where(r => r.PersonelCar == false).ToList<Car>();
                CarField.DataSource = ls;
                if (ls.Count < 1)
                    CarField.TextCombobox = "";
            }
            else
                if (staff != null && meansTransportCategories == MeansTransportCategories.Voiture_de_Service)
            {
                EntryForm.Fields[nameof(MissionOrder.Car)].Show();
                ManyToOneField CarField = EntryForm.Fields[nameof(MissionOrder.Car)] as ManyToOneField;
                List<Car> ls = new ModelContext().Cars.Where(r => r.PersonelCar == false).ToList<Car>();
                CarField.DataSource = ls;
                if (ls.Count < 1)
                    CarField.TextCombobox = "";
            }
            else
                if (staff == null && meansTransportCategories == MeansTransportCategories.Voiture_Personnel)
            {
                EntryForm.Fields[nameof(MissionOrder.Car)].Show();

            }
            else
                if (staff!=null &&  meansTransportCategories==MeansTransportCategories.Voiture_Personnel)
            {
                ManyToOneField CarField = EntryForm.Fields[nameof(MissionOrder.Car)] as ManyToOneField;

                List<Car> ls = new ModelContext().Cars.Where(r => r.Staff.Id == staff.Id).ToList<Car>();
                CarField.DataSource = ls;
                EntryForm.Fields[nameof(MissionOrder.Car)].Show();
                if (ls.Count < 1)
                    CarField.TextCombobox = "";
            }
        }
    }
}
