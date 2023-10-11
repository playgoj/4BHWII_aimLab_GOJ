import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
 
  title = 'HTLAimLabAngular';

  ChangeTitel(title:string)
  {
    this.title = "HLW aim Lab"
  }
}
