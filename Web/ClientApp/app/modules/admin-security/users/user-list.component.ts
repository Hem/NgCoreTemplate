import { User, UserService } from './user-service';
import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'UserList',
    templateUrl: './user-list.component.html',
    providers: [UserService],
})
export class UserListComponent {
    private users:User[];

    constructor(private userService:UserService) {}

    async ngOnInit() {
        this.users = await this.userService.getUsers();
    }
}
