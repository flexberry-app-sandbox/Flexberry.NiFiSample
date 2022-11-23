import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-ni-fi-sample-car', 'Unit | Model | i-i-s-ni-fi-sample-car', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-ni-fi-sample-brand',
    'model:i-i-s-ni-fi-sample-car-data',
    'model:i-i-s-ni-fi-sample-car',
    'model:i-i-s-ni-fi-sample-producing-country',
    'model:i-i-s-ni-fi-sample-spare-part',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
