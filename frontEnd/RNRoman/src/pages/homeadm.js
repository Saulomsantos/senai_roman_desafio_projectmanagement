import React, { Component } from 'react';
import { Text, View, StyleSheet } from 'react-native';

class HomeAdm extends Component {
    render() {
        return (
            <View style={styles.container}>
                <Text>Home ADM</Text>
            </View>
        )
    }
}

export default HomeAdm;

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});