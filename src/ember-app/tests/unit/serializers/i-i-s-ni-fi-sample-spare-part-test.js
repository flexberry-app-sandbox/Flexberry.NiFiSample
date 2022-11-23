import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-ni-fi-sample-spare-part', 'Unit | Serializer | i-i-s-ni-fi-sample-spare-part', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-ni-fi-sample-spare-part',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-ni-fi-sample-car-type',

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
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
