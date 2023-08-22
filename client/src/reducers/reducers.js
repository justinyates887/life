import { combineReducers } from 'redux';

const initialState = {
  view: 'Budget',
  // Other initial state properties if you have them
};

const viewReducer = (state = initialState.view, action) => {
  switch (action.type) {
    case 'SET_VIEW':
      return action.payload;
    default:
      return state;
  }
};

// You can add more reducers here if needed

const rootReducer = combineReducers({
  view: viewReducer,
  // Other reducers if needed
});

export default rootReducer;
