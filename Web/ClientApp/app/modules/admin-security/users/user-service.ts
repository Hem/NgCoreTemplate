import { Inject, Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

export interface User {
    id: number;
    firstName: string;
    lastName: string;
}

@Injectable()
export class UserService {

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) { }

    async getUsers(): Promise<User[]> {
        const resp = await this.http.get(`${this.baseUrl}api/admin/user/find`).toPromise();
        return await resp.json() as User[];
    }

}