import {
  defineNamespace,
  defineProjections,
  Model as BrandMixin
} from '../mixins/regenerated/models/i-i-s-ni-fi-sample-brand';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(BrandMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
