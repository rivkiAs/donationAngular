import { DonationType } from "./DonationType";
import { Donor } from "./Donor";
import { Keren } from "./Keren";

export class Donation{

    
    id:number=0;
    donationType:DonationType={"id":0,"nameType":""};
    donor:Donor={"tz":"","phoneMumber":"" ,"lastName":"","firstName":"","id":0,"email":"",cities:{"cityName":"","id":0}};
    amountPerBeat:number=0;
    numberOfBeats:number=0;
    keren:Keren={"catalogNumber": 0, "description" : "","percent" :0, "id":0, "target":0};

}




