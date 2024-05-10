import { Injectable } from '@angular/core';

@Injectable()
export class BaseEntity {
  Id: string = "";
  CreatedDate: Date | undefined;
  UpdatedDate: Date | undefined ;

}
