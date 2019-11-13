import { User } from '@/models/user.interface';
import Axios from 'axios';

export interface ApiClient {
    getAllUsers(): Promise<User[]>;
}

const apiClient: ApiClient = {
    getAllUsers() {
        return Axios.get<User[]>("api/Users")
            .then(response => response.data)
            .catch();
    }
}