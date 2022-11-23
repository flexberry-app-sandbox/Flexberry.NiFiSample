import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.ni-fi-sample.caption'),
          title: i18n.t('forms.application.sitemap.ni-fi-sample.title'),
          children: [{
            link: 'i-i-s-ni-fi-sample-brand-l',
            caption: i18n.t('forms.application.sitemap.ni-fi-sample.i-i-s-ni-fi-sample-brand-l.caption'),
            title: i18n.t('forms.application.sitemap.ni-fi-sample.i-i-s-ni-fi-sample-brand-l.title'),
            icon: 'paperclip',
            children: null
          }, {
            link: 'i-i-s-ni-fi-sample-car-l',
            caption: i18n.t('forms.application.sitemap.ni-fi-sample.i-i-s-ni-fi-sample-car-l.caption'),
            title: i18n.t('forms.application.sitemap.ni-fi-sample.i-i-s-ni-fi-sample-car-l.title'),
            icon: 'table',
            children: null
          }, {
            link: 'i-i-s-ni-fi-sample-producing-country-l',
            caption: i18n.t('forms.application.sitemap.ni-fi-sample.i-i-s-ni-fi-sample-producing-country-l.caption'),
            title: i18n.t('forms.application.sitemap.ni-fi-sample.i-i-s-ni-fi-sample-producing-country-l.title'),
            icon: 'archive',
            children: null
          }]
        }
      ]
    };
  }),
})