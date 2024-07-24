import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ToastrModule } from 'ngx-toastr';
import { TabsModule } from 'ngx-bootstrap/tabs';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right',
    }), // ToastrModule added
    BsDropdownModule.forRoot(),
    TabsModule.forRoot()
  ],
  exports:[
    ToastrModule,
    BsDropdownModule,
    TabsModule
  ]
})
export class SharedModule { }
