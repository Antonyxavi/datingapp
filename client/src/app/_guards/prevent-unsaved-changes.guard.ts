import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanDeactivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { MemberDetailComponent } from '../members/member-detail/member-detail.component';
import { ConfirmService } from '../_services/confirm.service';

@Injectable({
  providedIn: 'root'
})
export class PreventUnsavedChangesGuard implements CanDeactivate<unknown> {
 
   constructor(private confirmService: ConfirmService){}

  canDeactivate(component: MemberDetailComponent): Observable<boolean> | boolean
  {
    if(component.editForm.dirty)
    {
      return this.confirmService.confirm()
    }
    return true;
  }
  
}
