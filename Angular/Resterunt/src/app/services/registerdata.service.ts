import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RegisterdataService {
  private localStorageKey = 'formData';

  setFormData(data: any) {
    localStorage.setItem(this.localStorageKey, JSON.stringify(data));
  }

  getFormData() {
    const data = localStorage.getItem(this.localStorageKey);
    return data ? JSON.parse(data) : null;
  }
}
 

