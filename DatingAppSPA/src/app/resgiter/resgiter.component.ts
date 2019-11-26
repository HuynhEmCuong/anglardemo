import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-resgiter',
  templateUrl: './resgiter.component.html',
  styleUrls: ['./resgiter.component.css']
})
export class ResgiterComponent implements OnInit {
  model: any = {};
  @Input() valueFormHome: any;
  @Output() cancelRegister = new EventEmitter();
  registerForm: FormGroup;


  constructor(private authService: AuthService, private fb: FormBuilder) { }

  ngOnInit() {
    this.registerForm = new FormGroup({
      username: new FormControl('', Validators.required),
      password: new FormControl('',
        [Validators.required, Validators.minLength(4), Validators.maxLength(8)]),
      confirmPassword: new FormControl('', Validators.required)

    }, this.passwordMatchValidator);
  }

  creatRegisterForm() {

  }

  Cancel() {
    this.cancelRegister.emit(false);
    console.log('cancel');
  }

  passwordMatchValidator(g: FormGroup) {
    return g.get('password').value === g.get('confirmPassword').value ? null : { 'mismatch': true };
  }

  Register() {
    // this.authService.register(this.model).subscribe(res => {
    //   console.log('register success');
    // }, error => {
    //   console.log('register fail');
    // });
    console.log(this.registerForm.value);
  }
}
