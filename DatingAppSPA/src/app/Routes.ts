import { HomeComponent } from './home/home.component';
import { Routes } from '@angular/router';
import { MemberListComponent } from './member-list/member-list.component';
import { MessageComponent } from './message/message.component';
import { ListsComponent } from './lists/lists.component';
import { AuthGuard } from './_guards/auth.guard';




export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'members', component: MemberListComponent, canActivate: [AuthGuard] },
    { path: 'message', component: MessageComponent },
    { path: 'lists', component: ListsComponent },
    { path: '**', redirectTo: 'home', pathMatch: 'full' },
];
