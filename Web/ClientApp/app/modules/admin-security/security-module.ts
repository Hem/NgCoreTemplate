import { UserService } from './users/user-service';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { UserListComponent } from './users/user-list.component';
import { GroupListComponent } from './groups/group-list.component';
import { NgModule } from "@angular/core";

/**
 *  admin/security => Security Module
 *  
 *  admin/security/users
 *  admin/security/groups
 *  admin/security/permissions
 *  
 */
@NgModule({
    providers: [ UserService ],
    declarations: [
        UserListComponent,
        GroupListComponent
    ],
    imports: [
        CommonModule,
        RouterModule.forChild([
            { path: 'users', component: UserListComponent },
        ])
    ],
    exports: [
        RouterModule
    ]
})
export class SecurityModule {}