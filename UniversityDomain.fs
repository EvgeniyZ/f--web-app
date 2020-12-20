module UniversityDomain

open System

type StudentId = StudentId of int
type AdmissionYear = AdmissionYear of DateTime
type ReleaseYear = ReleaseYear of DateTime
type StudentAge = private StudentAge of int

module StudentAge =
    let private minimumAge = 17
    let private maximumAge = 120

    let create age =
        if age < minimumAge
        then Error $"{nameof (StudentAge)} must be greater than {minimumAge}"
        else if age > maximumAge
        then Error $"{nameof (StudentAge)} must be less then {maximumAge}"
        else Ok(StudentAge age)

type CourseId = CourseId of int

type Student =
    { Id: StudentId
      FirstName: string
      LastName: string
      Age: StudentAge
      CourseId: CourseId
      AdmissionYear: AdmissionYear
      ReleaseYear: ReleaseYear }

type Course =
    { Id: CourseId
      Name: string
      StudentIds: StudentId list }
