'use client'

import { Provider } from 'react-redux';
import { Home }  from '../pages/Home'
import store from '../store/store';
import '../assets/styles/globals.css';

function MyApp() {
  return (
    <Provider store={store}>
      <Home />
    </Provider>
  );
}

export default MyApp;
