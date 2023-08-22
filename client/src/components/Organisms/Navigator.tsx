import * as React from 'react';
import Divider from '@mui/material/Divider';
import Drawer, { DrawerProps } from '@mui/material/Drawer';
import List from '@mui/material/List';
import Box from '@mui/material/Box';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import HomeIcon from '@mui/icons-material/Home';
import AttachMoneyIcon from '@mui/icons-material/AttachMoney';
import ChecklistIcon from '@mui/icons-material/Checklist';
import SavingsIcon from '@mui/icons-material/Savings';
import EmojiEmotionsIcon from '@mui/icons-material/EmojiEmotions';
import SportsScoreIcon from '@mui/icons-material/SportsScore';
import BalanceIcon from '@mui/icons-material/Balance';
import SchoolIcon from '@mui/icons-material/School';
import HistoryEduIcon from '@mui/icons-material/HistoryEdu';
import LocalDiningIcon from '@mui/icons-material/LocalDining';
import FitnessCenterIcon from '@mui/icons-material/FitnessCenter';

const categories = [
  {
    id: 'Finance',
    children: [
      {
        id: 'Budget',
        icon: <AttachMoneyIcon />,
        active: true,
      },
      { id: 'Steps', icon: <ChecklistIcon /> },
      { id: 'Investments', icon: <SavingsIcon /> },
      { id: 'Wants', icon: <EmojiEmotionsIcon /> },
      { id: 'Goals', icon: <SportsScoreIcon /> },
      { id: 'Buying Power', icon: <BalanceIcon />, },
    ],
  },
  {
    id: 'Education',
    children: [
      { id: 'College', icon: <SchoolIcon /> },
      { id: 'Independant', icon: <HistoryEduIcon /> },
    ],
  },
  {
    id: 'Health',
    children: [
      { id: 'Nutrition', icon: <LocalDiningIcon /> },
      { id: 'Workout', icon: <FitnessCenterIcon /> }
    ]
  }
];

const item = {
  py: '2px',
  px: 3,
  color: 'rgba(255, 255, 255, 0.7)',
  '&:hover, &:focus': {
    bgcolor: 'rgba(255, 255, 255, 0.08)',
  },
};

const itemCategory = {
  boxShadow: '0 -1px 0 rgb(255,255,255,0.1) inset',
  py: 1.5,
  px: 3,
};

export default function Navigator(props: DrawerProps) {
  const { ...other } = props;

  return (
    <Drawer variant="permanent" {...other}>
      <List disablePadding>
        <ListItem sx={{ ...item, ...itemCategory, fontSize: 30, color: '#fff', height: '92px' }}>
          Life
        </ListItem>
        <ListItem sx={{ ...item, ...itemCategory }}>
          <ListItemIcon>
            <HomeIcon />
          </ListItemIcon>
          <ListItemText>Dashboard</ListItemText>
        </ListItem>
        {categories.map(({ id, children }) => (
          <Box key={id} sx={{ bgcolor: '#00BD5F' }}>
            <ListItem sx={{ py: 2, px: 3 }}>
              <ListItemText sx={{ color: '#fff' }}>{id}</ListItemText>
            </ListItem>
            {children.map(({ id: childId, icon, active }) => (
              <ListItem disablePadding key={childId}>
                <ListItemButton selected={active} sx={item}>
                  <ListItemIcon>{icon}</ListItemIcon>
                  <ListItemText>{childId}</ListItemText>
                </ListItemButton>
              </ListItem>
            ))}
            <Divider sx={{ mt: 2 }} />
          </Box>
        ))}
      </List>
    </Drawer>
  );
}