import { SaleTypes } from "./SaleTypes"
import { Subject } from "./Subject"

export interface Book{
    Id: number
    Title: string
    AuthorName: string
    PublishingCompany: string
    Edition: number
    PublicationDate: string
    Subjects: Subject[]
    SaleTypes: SaleTypes[]
}