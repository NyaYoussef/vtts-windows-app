// File:    EmploisTemps.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:53:52
// Purpose: Definition of Class EmploisTemps

using App.Gwin.Entities;
using System;
using vtts.Entities.SessionManagement;
using vtts.Entities.StaffManagement;

namespace vtts.Entities.PlaningManagement
{
   public class TimeTable :BaseEntity
   {
      
      public  DateTime StartDate { get; set; }
      public  DateTime EndDate { get; set; }
      
     // public List<SeancePlanning> seancePlanning;
      
    
      public Former Former { get; set; }
      
    
     
      public TrainingYear TrainingYear;
      
    
   
   }
}