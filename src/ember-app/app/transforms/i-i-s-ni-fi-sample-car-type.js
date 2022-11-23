import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import CarTypeEnum from '../enums/i-i-s-ni-fi-sample-car-type';

export default FlexberryEnum.extend({
  enum: CarTypeEnum,
  sourceType: 'IIS.NiFiSample.CarType'
});
