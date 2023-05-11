import { HRSystemTemplatePage } from './app.po';

describe('HRSystem App', function() {
  let page: HRSystemTemplatePage;

  beforeEach(() => {
    page = new HRSystemTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
