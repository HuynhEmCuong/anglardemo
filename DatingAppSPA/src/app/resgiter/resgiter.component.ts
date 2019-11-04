import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-resgiter',
  templateUrl: './resgiter.component.html',
  styleUrls: ['./resgiter.component.css']
})
export class ResgiterComponent implements OnInit {
  model: any = {};
  @Input() valueFormHome: any;
  constructor() { }

  ngOnInit() {
  }


  Cancel() {
    console.log('cancel');
  }

  Register() {
    console.log('Register');
  }
}
