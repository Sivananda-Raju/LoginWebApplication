import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthserviceService } from '../authservice.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  formGroup!: FormGroup;
  constructor(private authservice: AuthserviceService) { }


  ngOnInit(): void {
    this.initForm();
  }
  initForm() {
    this.formGroup = new FormGroup({
      UserName: new FormControl('', [Validators.required]),
      Password: new FormControl('', [Validators.required])
    })
  }
  loginProcess() {
    if (this.formGroup.valid) {
      this.authservice.login(this.formGroup.value).subscribe(result => {
        if (result.success) {
          console.log(result);
        }
        else {
          console.log(result);
        }
      })
    }
  }

}
