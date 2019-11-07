import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { RouterModule } from '@angular/router';



// import { from } from 'rxjs';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { ResgiterComponent } from './resgiter/resgiter.component';
import { AuthService } from './_services/auth.service';
import { ErrorInterceptor } from './_services/Error.insterceptor';
import { AlertifyService } from './_services/alertify.service';
import { ListsComponent } from './lists/lists.component';
import { MemberListComponent } from './member-list/member-list.component';
import { MessageComponent } from './message/message.component';
import { appRoutes } from './Routes';
import { AuthGuard } from './_guards/auth.guard';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      ResgiterComponent,
      ListsComponent,
      MemberListComponent,
      MessageComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      BsDropdownModule.forRoot(),
      RouterModule.forRoot(appRoutes)
   ],
   providers: [
      AuthService,
      ErrorInterceptor,
      AlertifyService,
      AuthGuard
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
