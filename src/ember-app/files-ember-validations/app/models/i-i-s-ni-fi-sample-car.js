import {
  defineNamespace,
  defineProjections,
  Model as CarMixin
} from '../mixins/regenerated/models/i-i-s-ni-fi-sample-car';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(CarMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
