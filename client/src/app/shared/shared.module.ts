import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { PagingHeaderComponent } from './paging-header/paging-header.component';


@NgModule({
  declarations: [
    PagingHeaderComponent
  ],
  imports: [
    CommonModule,
    // create  as a singleton
    PaginationModule.forRoot()
  ],
  // exports array
  exports: [
    PaginationModule,
    PagingHeaderComponent
  ]
})
export class SharedModule { }
