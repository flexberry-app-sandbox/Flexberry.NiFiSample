import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-ni-fi-sample-brand-l');
  this.route('i-i-s-ni-fi-sample-brand-e',
  { path: 'i-i-s-ni-fi-sample-brand-e/:id' });
  this.route('i-i-s-ni-fi-sample-brand-e.new',
  { path: 'i-i-s-ni-fi-sample-brand-e/new' });
  this.route('i-i-s-ni-fi-sample-car-l');
  this.route('i-i-s-ni-fi-sample-car-e',
  { path: 'i-i-s-ni-fi-sample-car-e/:id' });
  this.route('i-i-s-ni-fi-sample-car-e.new',
  { path: 'i-i-s-ni-fi-sample-car-e/new' });
  this.route('i-i-s-ni-fi-sample-producing-country-l');
  this.route('i-i-s-ni-fi-sample-producing-country-e',
  { path: 'i-i-s-ni-fi-sample-producing-country-e/:id' });
  this.route('i-i-s-ni-fi-sample-producing-country-e.new',
  { path: 'i-i-s-ni-fi-sample-producing-country-e/new' });
});

export default Router;
