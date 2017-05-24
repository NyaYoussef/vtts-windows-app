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
                          ComboBoxField missioncarfield = field as ComboBoxField;
                          MeansTransportCategories meansTransportCategories =(MeansTransportCategories)missioncarfield.Value;
                          

                          if(meansTransportCategories == MeansTransportCategories.Public)
                          {
                              EntryForm.Fields[nameof(MissionOrder.Car)].Hide();
                            //ManyToOneField CarField = EntryForm.Fields[nameof(MissionOrder.Car)] as ManyToOneField;

                            //List<Car> ls =new ModelContext().Cars.Where(r=>r.PersonelCar==false).ToList<Car>();
                            
                        }
                          else
                            if(meansTransportCategories==MeansTransportCategories.Voiture_Personnel)
                        {
                            EntryForm.Fields[nameof(MissionOrder.Car)].Show();
                            ManyToOneField CarField = EntryForm.Fields[nameof(MissionOrder.Car)] as ManyToOneField;
                            ManyToOneField staffField = EntryForm.Fields[nameof(MissionOrder.Staff)] as ManyToOneField;
                            Staff staff = staffField.SelectedItem as Staff;

                            List<Car> ls = new ModelContext().Cars.Where(r => r.Staff.Id == staff.Id).ToList<Car>();
                            CarField.DataSource = ls;
                           
                        }
                          else
                            if(meansTransportCategories==MeansTransportCategories.Voiture_de_Service)
                            {
                                    EntryForm.Fields[nameof(MissionOrder.Car)].Show();
                                    ManyToOneField CarField = EntryForm.Fields[nameof(MissionOrder.Car)] as ManyToOneField;
                                    List<Car> ls = new ModelContext().Cars.Where(r => r.PersonelCar == false).ToList<Car>();
                                    CarField.DataSource = ls;
                            if (ls.Count < 1)
                                CarField.TextCombobox = "";
                        }


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
                        Staff Staf = missionStaffield.SelectedItem as Staff;
                        if(Staf!=null)
                        {
                            ManyToOneField CarField = EntryForm.Fields[nameof(MissionOrder.Car)] as ManyToOneField;

                            List<Car> ls = new ModelContext().Cars.Where(r => r.Staff.Id == Staf.Id).ToList<Car>();
                            CarField.DataSource = ls;
                           
                        }
                    }
                    break;

            }


          

        }
    }
}
