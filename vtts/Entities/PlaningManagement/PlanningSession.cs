// File:    SeancePlanning.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:53:52
// Purpose: Definition of Class SeancePlanning

using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using vtts.Entities.StaffManagement;

namespace vtts.Entities.PlaningManagement
{
   public class PlanningSession:BaseEntity
   {
      
      public int Day { get; set; }
      public  int StartHour { get; set; }
      public  int EndHour { get; set; }
      
      public virtual List<Former> Formers { get; set; }
      
     
   
   }
}