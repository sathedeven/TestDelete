import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'vendor',
    templateUrl: './vendor.component.html'
})

export class VendorComponent {
    public vendors: Vendor[]

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Vendors').subscribe(result => {
            this.vendors = result.json() ; console.log(this.vendors);
        }, error => console.error(error));
    }

    onRowSelect(event:object) {
    }
}



interface Vendor {
    id: number;
    vendorName: string;
    ownerName: string;
    ownerMobile: string;
    ownerEmail: string;
    supervisorName: string;
    isActive: boolean;
}
