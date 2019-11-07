import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-resgiter',
  templateUrl: './resgiter.component.html',
  styleUrls: ['./resgiter.component.css']
})
export class ResgiterComponent implements OnInit {
  model: any = {};
  @Input() valueFormHome: any;
  @Output() cancelRegister = new EventEmitter();
  constructor(private authService: AuthService) { }

  ngOnInit() {
  }


  Cancel() {
    this.cancelRegister.emit(false);
    console.log('cancel');
  }

  Register() {
    this.authService.register(this.model).subscribe(res => {
      console.log('register success');
    }, error => {
      console.log('register fail');
    });
  }
}
