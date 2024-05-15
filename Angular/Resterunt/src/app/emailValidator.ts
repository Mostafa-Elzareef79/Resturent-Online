import { AbstractControl, ValidatorFn } from '@angular/forms';

export function emailValidator(): ValidatorFn {
  return (control: AbstractControl): { [key: string]: any } | null => {
    const email: string = control.value;
    if (!email || !email.toLowerCase().endsWith('.com')) {
      return { 'invalidEmail': true };
    }
    return null;
  };
}

