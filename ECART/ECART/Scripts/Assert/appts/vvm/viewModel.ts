module ECart.ViewModel {

    export interface UserMvvm {
        Id: number;
        Email: string;
        Password: string;
        Name: string;
        UserType: number;
        RegDate: Date;
    }
    export interface ItemMvvm {
        Id: number;
        Name: string;
        Description: string;
        Price: number;
        Image: string;
        Category: number;
    }

    export interface CheckoutMvvm {
        Id: number;
        ItemId: number;
        ItemPrice: number;
        NumberOfUnits: number;
        BatchId: number;
    }
    export interface CheckoutSummeryMvvm {
        InvoiceId: number;
        UserId: number;
        TotalAmount: number;
        PaymentMethod: number;
        CardNumber: string;
        CheckoutDate: Date;
    }
}