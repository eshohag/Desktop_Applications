Select * from Patients
Select * from CabinInfo
Select * from Drug
Select * from Treatment
Select * from Doctors
Select * from Payment
Select * from DoctorsSchedule
select * from Nurses
select * from LoginInfo

select Doctors.Name,Doctors.Department from Doctors 
  join DoctorsSchedule on Doctors.ID=DoctorsSchedule.DoctorID where Shift='Morning'
SELECT Doctors.Name,Doctors.Department,Doctors.Education,Doctors.MobileNo,Doctors.Speciality,DoctorsSchedule.Shift  from Doctors Left join DoctorsSchedule on Doctors.ID=DoctorsSchedule.DoctorID where Shift='Evening'






