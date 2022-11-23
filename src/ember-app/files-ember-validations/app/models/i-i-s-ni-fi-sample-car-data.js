import {
  defineNamespace,
  Model as CarDataMixin
} from '../mixins/regenerated/models/i-i-s-ni-fi-sample-car-data';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(CarDataMixin, {
});

defineNamespace(Model);

export default Model;
