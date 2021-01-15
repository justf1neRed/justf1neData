export class Item {

    public itemID: number;
    public Name: string;
    public Price: number;

    constructor(itemID: number, Name: string, Price: number){
        this.itemID = itemID;
        this.Name = Name;
        this.Price = Price;
    }
}
